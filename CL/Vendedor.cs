using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.CL
{
    public class Vendedor:Persona
    {
        public int Id {  get; set; }
        public string TipoCapacitacion {  get; set; }
        public int HorasCapacitacion { get; set; }
    }
}
