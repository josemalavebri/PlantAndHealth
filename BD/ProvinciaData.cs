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
    public class ProvinciaData
    {
        public static void AñadirProvincia(Provincia provincia)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spAñadirProvincia", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", provincia.Nombre);
                    cmd.Parameters.AddWithValue("@RegionId", provincia.Region.Id);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Provincia> ObtenerProvincias()
        {
            List<Provincia> provincias = new List<Provincia>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerProvincias", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {                            
                            Provincia provincia = new Provincia
                            {
                                Id = Convert.ToInt32(reader["PROVINCIA_ID"]),
                                Nombre = reader["PROVINCIA_NOMBRE"].ToString(),
                                Region = new Region
                                {
                                    Id = Convert.ToInt32(reader["REGION_ID"]),
                                    Nombre = reader["REGION"].ToString()
                                }
                            };
                            provincias.Add(provincia);
                        }
                    }
                }
            }
            return provincias;
        }
    }
}
