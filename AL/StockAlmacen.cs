using PlantAndHealth.CL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.AL
{
    public class StockAlmacen
    {
        private List<Stock> stock;  

        public StockAlmacen()
        {
            stock = new List<Stock>();
        }

        public void AñadirStock(Stock stock)
        {
            this.stock.Add(stock);
        }

        public List<Stock> ObtenerStocks()
        {
            return stock;
        }
    }
}
