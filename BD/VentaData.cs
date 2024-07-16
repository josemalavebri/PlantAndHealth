using PlantAndHealth.CL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.BD
{
    public class VentaData
    {
        public static void AñadirVenta(Ventas ventas)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SP_CREAR_VENTA", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", ventas.Cliente.Numero);
                    cmd.Parameters.AddWithValue("@ID_VENDEDOR", ventas.Vendedor.Id);
                    cmd.Parameters.AddWithValue("@BODEGA_ID", ventas.Bodega.Id);
                    cmd.Parameters.AddWithValue("@FECHA", ventas.Fecha);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Ventas> ObtenerVentas()
        {
            List<Ventas> ventas = new List<Ventas>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerVentas", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ventas venta = new Ventas
                            {
                                Documento = reader["DOCUMENTO"].ToString(),
                                Fecha = Convert.ToDateTime(reader["FECHA"]),
                                Cliente = new Cliente
                                {
                                    Numero = Convert.ToInt32(reader["ID_CLIENTE"])
                                },
                                TipoDocumento = reader["TIPO_DOCUMENTO"].ToString(),
                                Vendedor = new Vendedor
                                {
                                    Id = Convert.ToInt32(reader["ID_VENDEDOR"])
                                },
                                TotalNeto = Convert.ToDouble(reader["TOTAL_NETO"]),
                                Impuesto = Convert.ToDouble(reader["IMPUESTO"]),
                                TotalDocumento = Convert.ToDouble(reader["TOTAL_DOCUMENTO"]),
                                Bodega = new Bodega
                                {
                                    Id = Convert.ToInt32(reader["BODEGA_ID"])
                                }
                            };
                            ventas.Add(venta);
                        }
                    }
                }
            }
            return ventas;
        }
    }
}
