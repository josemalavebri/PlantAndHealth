using PlantAndHealth.CL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace PlantAndHealth.BD
{
    internal class DetalleVentaData
    {
        public static void AñadirDetalleVenta(DetalleVenta detalleVenta)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SP_CREAR_DETALLE_VENTA", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Documento", detalleVenta.Documento);
                    cmd.Parameters.AddWithValue("@CodigoProducto", detalleVenta.CodigoProducto);
                    cmd.Parameters.AddWithValue("@Cantidad", detalleVenta.Cantidad);
                    cmd.Parameters.AddWithValue("@Total", detalleVenta.Total);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<DetalleVenta> ObtenerDetalleVenta()
        {
            List<DetalleVenta> detalleVentas= new List<DetalleVenta>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerDetalleVenta", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DetalleVenta detalleVenta = new DetalleVenta
                            {
                                CodigoProducto = reader["DOCUMENTO"].ToString(),
                                Documento = reader["CODIGO_PRODUCTO"].ToString(),
                                PrecioUnitario = double.Parse(reader["PRECIO_UNITARIO"].ToString()),
                                Cantidad = int.Parse(reader["CANTIDAD"].ToString()),
                                Total =  double.Parse(reader["TOTAL"].ToString())
                            };
                            detalleVentas.Add(detalleVenta);
                        }
                    }
                }
            }
            return detalleVentas;
        }
    }
}
