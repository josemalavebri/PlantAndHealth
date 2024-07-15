using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.CL
{
    public class Ventas
    {
        public string Documento {  get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public string TipoDocumento { get; set; }
        public Vendedor Vendedor { get; set; }
        public double TotalNeto {  get; set; }
        public double Impuesto {  get; set; }
        public double TotalDocumento {  get; set; }
        public Bodega Bodega { get; set; }
        public List<DetalleVenta> Detalle { get; set; }
    }
}
