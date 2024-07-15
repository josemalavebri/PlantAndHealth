using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PlantAndHealth.CL;

namespace PlantAndHealth.BD
{
    public class RegionData
    {
        public static void AñadirRegion(Region region)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spAñadirRegion", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", region.Nombre);
                    
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Region> ObtenerRegiones()
        {
            List<Region> regiones = new List<Region>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerRegiones", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Region region = new Region();
                            region.Id= Convert.ToInt32(reader["REGION_ID"]);
                            region.Nombre = reader["REGION"].ToString();                                
                                //Convert.ToDecimal(reader["Precio"])                            
                            regiones.Add(region);
                        }
                    }
                }
            }
            return regiones;
        }
    }
}
