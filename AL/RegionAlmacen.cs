using PlantAndHealth.CL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.AL
{
    public class RegionAlmacen
    {
        private List<Region> regiones;

        public RegionAlmacen()
        {
            regiones = new List<Region>();
        }

        public void AñadirRegion(Region region)
        {
            regiones.Add(region);
        }

        public List<Region> ObtenerRegiones()
        {
            return regiones;
        }
        
        /*public override string ToString()
        {
            return $"Clientes almacenados: {clientes.Count}";
        }*/
    }
}
