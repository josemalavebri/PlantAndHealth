using PlantAndHealth.CL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.AL
{
    public class ProvinciaAlmacen
    {
        private List<Provincia> provincia;

        public ProvinciaAlmacen()
        {
            provincia = new List<Provincia>();
        }

        public void AñadirProvincia(Provincia provincia)
        {
            this.provincia.Add(provincia);
        }

        public List<Provincia> ObtenerProvincias()
        {
            return provincia;
        }

        /*internal void AñadirRegion(System.Drawing.Region region)
        {
            throw new NotImplementedException();
        }*/

    }
}
