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
    public class BodegaData
    {
        public static void AñadirBodega(Bodega bodega)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spAñadirBodega", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", bodega.Nombre);
                    cmd.Parameters.AddWithValue("@SucursalId", bodega.Sucursal.Id);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Bodega> ObtenerBodegas()
        {
            List<Bodega> bodegas = new List<Bodega>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerBodegas", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Bodega bodega = new Bodega
                            {
                                Id = Convert.ToInt32(reader["BODEGA_ID"]),
                                Nombre = reader["BODEGA_NOMBRE"].ToString(),
                                Sucursal = new Sucursal
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
                                }
                            };
                            bodegas.Add(bodega);
                        }
                    }
                }
            }
            return bodegas;
        }
    }
}
