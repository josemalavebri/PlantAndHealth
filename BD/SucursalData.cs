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
    public class SucursalData
    {
        public static void AñadirSucursal(Sucursal sucursal)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spAñadirSucursal", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", sucursal.Nombre);
                    cmd.Parameters.AddWithValue("@ComunaId", sucursal.Comuna.Id);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Sucursal> ObtenerSucursales()
        {
            List<Sucursal> sucursales = new List<Sucursal>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerSucursales", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Sucursal sucursal = new Sucursal
                            {
                                Id = Convert.ToInt32(reader["SUCURSAL_ID"]),
                                Nombre = reader["NOMBRE_SUCURSAL"].ToString(),
                                Comuna = new Comuna
                                {
                                    Id = Convert.ToInt32(reader["COMUNA_ID"]),
                                    Nombre = reader["COMUNA_NOMBRE"].ToString(),
                                     Provincia = new Provincia
                                     {
                                         Id = Convert.ToInt32(reader["PROVINCIA_ID"]),
                                         Nombre = reader["PROVINCIA_NOMBRE"].ToString(),
                                         Region = new Region
                                         {
                                             Id = Convert.ToInt32(reader["REGION_ID"]),
                                             Nombre = reader["REGION"].ToString()
                                         }
                                     }
                                }
                            };
                            sucursales.Add(sucursal);
                        }
                    }
                }
            }
            return sucursales;
        }
    }
}
