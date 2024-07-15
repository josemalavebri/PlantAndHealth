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
    public class ComunaData
    {
        public static void AñadirComuna(Comuna comuna)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spAñadirComuna", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", comuna.Nombre);
                    cmd.Parameters.AddWithValue("@ProvinciaId", comuna.Provincia.Id);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Comuna> ObtenerComunas()
        {
            List<Comuna> comunas = new List<Comuna>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerComunas", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Comuna comuna = new Comuna
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
                            };
                            comunas.Add(comuna);
                        }
                    }
                }
            }
            return comunas;
        }
    }
}
