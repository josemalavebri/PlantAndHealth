using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.CL
{
    public class DetalleVenta
    {
        public string Documento {  get; set; }
        public string CodigoProducto {  get; set; }
        public double PrecioUnitario {  get; set; }
        public int Cantidad {  get; set; }
        public double Total {  get; set; }
    }
}
