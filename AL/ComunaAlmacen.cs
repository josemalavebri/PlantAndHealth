using PlantAndHealth.CL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.AL
{
    public class ComunaAlmacen
    {
        private List<Comuna> comuna;

        public ComunaAlmacen()
        {
            comuna = new List<Comuna>();
        }

        public void AñadirComuna(Comuna comuna)
        {
            this.comuna.Add(comuna);
        }

        public List<Comuna> ObtenerComunas()
        {
            return comuna;
        }
    }
}
