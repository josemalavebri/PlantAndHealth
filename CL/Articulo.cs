using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.CL
{
    public class Articulo
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Familia { get; set; }
        public double PrecioUnitario { get; set;  }
        public double Costo {  get; set; }
    }
}
