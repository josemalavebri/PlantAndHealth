using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.CL
{
    public class Region
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Sobrescribir el método ToString para devolver la descripción de la región
        public override string ToString()
        {
            return Nombre;
        }
    }
}
