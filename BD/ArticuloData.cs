using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlantAndHealth.CL;

namespace PlantAndHealth.BD
{
    public class ArticuloData
    {
        public static void AñadirArticulo(Articulo articulo)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spAñadirArticulo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", articulo.Id);
                    cmd.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                    cmd.Parameters.AddWithValue("@Familia", articulo.Familia);
                    cmd.Parameters.AddWithValue("@Precio", articulo.PrecioUnitario);
                    cmd.Parameters.AddWithValue("@Costo", articulo.Costo);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Articulo> ObtenerArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerArticulos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Articulo articulo = new Articulo();
                            articulo.Id = reader["CODIGO_PRODUCTO"].ToString();
                            articulo.Nombre = reader["NOMBRE"].ToString();
                            articulo.Familia = reader["FAMILIA"].ToString();
                            articulo.PrecioUnitario=Convert.ToDouble(reader["PRECIO_UNITARIO"]);
                            articulo.Costo = Convert.ToDouble(reader["COSTO_UNITARIO"]);
                            //Convert.ToDecimal(reader["Precio"])                            
                            articulos.Add(articulo);
                        }
                    }
                }
            }
            return articulos;
        }
    }
}
