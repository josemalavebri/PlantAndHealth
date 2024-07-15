using PlantAndHealth.CL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.AL
{
    public class SucursalAlmacen
    {
        private List<Sucursal> sucursal;

        public SucursalAlmacen()
        {
            sucursal = new List<Sucursal>();
        }

        public void AñadirSucursal(Sucursal sucursal)
        {
            this.sucursal.Add(sucursal);
        }

        public List<Sucursal> ObtenerSucursales()
        {
            return sucursal;
        }
    }
}
