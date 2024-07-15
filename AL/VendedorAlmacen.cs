using PlantAndHealth.CL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.AL
{
    public class VendedorAlmacen
    {
        private List<Vendedor> vendedor;

        public VendedorAlmacen()
        {
            vendedor = new List<Vendedor>();
        }

        public void AñadirVendedor(Vendedor vendedor)
        {
            this.vendedor.Add(vendedor);
        }

        public List<Vendedor> ObtenerVendedores()
        {
            return vendedor;
        }
    }
}
