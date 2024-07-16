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
    public class ClienteData
    {
        public static void AñadirCliente(Cliente clientes)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spAñadirCliente", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NOMBRE", clientes.Nombres);
                    cmd.Parameters.AddWithValue("@APELLIDO", clientes.Apellidos);
                    cmd.Parameters.AddWithValue("@EDAD", clientes.Edad);
                    cmd.Parameters.AddWithValue("@ESTADO_CIVIL", clientes.EstadoCivil);
                    cmd.Parameters.AddWithValue("@RESIDENCIA", clientes.Residencia);
                    cmd.Parameters.AddWithValue("@ORIGEN", clientes.Origen);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Cliente> ObtenerCliente()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SP_OBTENER_CLIENTE", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente
                            {
                                Numero = reader["NRO"] != DBNull.Value ? Convert.ToInt32(reader["NRO"]) : 0,
                                Id = reader["ID_CLIENTE"] == DBNull.Value ? reader["ID_CLIENTE"].ToString() : string.Empty,
                                Nombres = reader["NOMBRE"] != DBNull.Value ? reader["NOMBRE"].ToString() : string.Empty,
                                Apellidos = reader["APELLIDO"] != DBNull.Value ? reader["APELLIDO"].ToString() : string.Empty,
                                Edad = reader["EDAD"] != DBNull.Value ? Convert.ToInt32(reader["EDAD"]) : 0,
                                EstadoCivil = reader["ESTADO_CIVIL"] != DBNull.Value ? reader["ESTADO_CIVIL"].ToString() : string.Empty,
                                Residencia = reader["RESIDENCIA"] != DBNull.Value ? reader["RESIDENCIA"].ToString() : string.Empty,
                                Origen = reader["ORIGEN"] != DBNull.Value ? reader["ORIGEN"].ToString() : string.Empty

                            };
                            clientes.Add(cliente);
                        }
                    }
                }
            }
            return clientes;
        }
    }
}
