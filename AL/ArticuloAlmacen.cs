using PlantAndHealth.CL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.AL
{
    public class ArticuloAlmacen
    {
        private List<Articulo> articulo;

        public ArticuloAlmacen()
        {
            articulo = new List<Articulo>();
        }

        public void AñadirArticulo(Articulo articulo)
        {
            this.articulo.Add(articulo);
        }

        public List<Articulo> ObtenerArticulos()
        {
            return articulo;
        }
    }
}
