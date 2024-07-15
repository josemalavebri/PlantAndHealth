using PlantAndHealth.CL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantAndHealth.AL
{
    public class ClienteAlmacen
    {
        private List<Cliente> cliente;

        public ClienteAlmacen()
        {
            cliente = new List<Cliente>();
        }

        public void AñadirCliente(Cliente cliente)
        {
            this.cliente.Add(cliente);
        }

        public List<Cliente> ObtenerClientes()
        {
            return cliente;
        }
    }
}
