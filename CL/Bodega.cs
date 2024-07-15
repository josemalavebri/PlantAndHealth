using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.CL
{
    public class Bodega
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Sucursal Sucursal { get; set; }
    }
}
