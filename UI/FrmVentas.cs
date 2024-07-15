using PlantAndHealth.BD;
using PlantAndHealth.CL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PlantAndHealth.UI
{
    public partial class FrmVentas : Form
    {
        Ventas venta = new Ventas();
        public FrmVentas()
        {
            InitializeComponent();
            comboBoxClientes.DataSource = ClienteData.ObtenerCliente();
            comboBoxClientes.DisplayMember = "Nombres";
            comboBoxClientes.ValueMember = "Numero";

            comboBoxBodega.DataSource = BodegaData.ObtenerBodegas();
            comboBoxBodega.DisplayMember = "Nombre";
            comboBoxBodega.ValueMember = "Id";

            comboBoxVendedores.DataSource = VendedorData.ObtenerVendedor();
            comboBoxVendedores.DisplayMember = "Nombres";
            comboBoxVendedores.ValueMember = "Id";
            Global.LimpiarControles(this);
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            //Global.secuencia = Global.secuencia + 1;
            //lbl_codigo.Text = "N° " + Global.GeneraSecuenciaVentas();
            /*comboBoxClientes.DataSource = ClientesData.ObtenerCliente();
            comboBoxClientes.DisplayMember = "Nombre";
            comboBoxClientes.ValueMember = "Id";

            comboBoxBodega.DataSource = BodegaData.ObtenerBodegas();
            comboBoxBodega.DisplayMember = "Nombre";
            comboBoxBodega.ValueMember = "Id";

            comboBoxVendedores.DataSource = VendedoresData.ObtenerVendedor;
            comboBoxVendedores.DisplayMember = "Nombres";
            comboBoxVendedores.ValueMember = "Id";
            Global.LimpiarControles(this);*/
            
            
        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)comboBoxClientes.SelectedItem;
            if (clienteSeleccionado != null)
            {
                textBoxNombres.Text = clienteSeleccionado.Nombres;
                textBoxApellidos.Text = clienteSeleccionado.Apellidos;                
            }
        }

        private void groupBox_informacion_Enter(object sender, EventArgs e)
        {

        }
    }
}
