using PlantAndHealth.CL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.AL
{
    public class BodegaAlmacen
    {
        private List<Bodega> bodega;

        public BodegaAlmacen()
        {
            bodega = new List<Bodega>();
        }

        public void AñadirBodega(Bodega bodega)
        {
            this.bodega.Add(bodega);
        }

        public List<Bodega> ObtenerBodegas()
        {
            return bodega;
        }
    }
}
