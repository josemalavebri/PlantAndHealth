using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.CL
{
    public class Stock
    {
        public int Id {  get; set; }
        public Bodega Bodega { get; set; }
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }
    }
}
