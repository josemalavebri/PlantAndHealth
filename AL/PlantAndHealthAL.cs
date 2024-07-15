using PlantAndHealth.CL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.AL
{
    public class PlantAndHealthAL
    {
        public RegionAlmacen Region { get; set; }
        public ProvinciaAlmacen Provincia { get; set; }
        public ComunaAlmacen Comuna { get; set; }
        public SucursalAlmacen Sucursal {  get; set; }
        public BodegaAlmacen Bodega { get; set; }
        public ArticuloAlmacen Articulo { get; set; }

        public PlantAndHealthAL()
        {            
            Region = new RegionAlmacen();
            Provincia=new ProvinciaAlmacen();
            Comuna=new ComunaAlmacen();
            Sucursal=new SucursalAlmacen();
            Bodega = new BodegaAlmacen();
            Articulo=new ArticuloAlmacen();
        }
    }
}
