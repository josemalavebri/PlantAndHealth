using System.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.BD
{
    public static class DatabaseConnection
    {
        //private static string connectionString = "Server=ENTERPRISE/DESARROLLO;Database=PlantAndHealth;User Id=sa;Password=P2ssw0rd;";
        private static string connectionString = ("server=Robert; database=PlantAndHealth2; Integrated Security=true; TrustServerCertificate=true");
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
