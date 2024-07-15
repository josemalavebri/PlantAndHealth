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
    public class VendedorData
    {
        public static void AñadirVendedor(Vendedor vendedores)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spAñadirVendedor", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", vendedores.Nombres);
                    cmd.Parameters.AddWithValue("@Apellido", vendedores.Apellidos);
                    cmd.Parameters.AddWithValue("@[TIPO_CAPACITACION]", vendedores.TipoCapacitacion);
                    cmd.Parameters.AddWithValue("@HORAS_CAPACITACION", vendedores.HorasCapacitacion);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Vendedor> ObtenerVendedor()
        {
            List<Vendedor> vendedores = new List<Vendedor>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SP_OBTENER_POR_VENDEDORES", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Vendedor vendedor = new Vendedor
                            {
                                Id = Convert.ToInt32(reader["ID_VENDEDOR"]),
                                Nombres = reader["Nombre"].ToString(),
                                Apellidos = reader["Apellido"].ToString(),
                                TipoCapacitacion = reader["TIPO_ CAPACITACION"].ToString(),
                                HorasCapacitacion = Convert.ToInt32(reader["HORAS_CAPACITACION"])
                            };
                            vendedores.Add(vendedor);
                        }
                    }
                }
            }
            return vendedores;
        }
    }
}
