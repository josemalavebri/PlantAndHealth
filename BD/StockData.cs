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
    public class StockData
    {
        public static void AñadirStock(Stock stock)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spAñadirStock", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdBodega", stock.Bodega.Id);
                    cmd.Parameters.AddWithValue("@IdArticulo", stock.Articulo.Id);
                    cmd.Parameters.AddWithValue("@Cantidad", stock.Cantidad);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Stock> ObtenerStocks()
        {
            List<Stock> stocks = new List<Stock>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerStocks", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Stock stock = new Stock
                            {
                                Id = Convert.ToInt32(reader["STOCK_ID"]),
                                Bodega = new Bodega
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
                                },
                                Articulo = new Articulo
                                {
                                    Id = reader["CODIGO_PRODUCTO"].ToString(),
                                    Nombre = reader["NOMBRE"].ToString(),
                                    Familia = reader["FAMILIA"].ToString(),
                                    PrecioUnitario = Convert.ToDouble(reader["PRECIO_UNITARIO"]),
                                    Costo = Convert.ToDouble(reader["COSTO_UNITARIO"])
                                }
                            };
                            stocks.Add(stock);
                        }
                    }
                }
            }
            return stocks;
        }
    }
}
