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
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            //Global.secuencia = Global.secuencia + 1;
            lbl_codigo.Text = "N° " + Global.GeneraSecuenciaVentas();
            comboBoxClientes.DataSource = Global.ClienteAlmacen.ObtenerClientes();
            comboBoxClientes.DisplayMember = "Id";
            comboBoxClientes.ValueMember = "Id";

            comboBoxBodega.DataSource = Global.BodegaAlmacen.ObtenerBodegas();
            comboBoxBodega.DisplayMember = "Nombre";
            comboBoxBodega.ValueMember = "Nombre";
            comboBoxVendedores.DataSource = Global.VendedorAlmacen.ObtenerVendedores();
            comboBoxVendedores.DisplayMember = "Nombres";

            comboBoxVendedores.ValueMember = "Nombres";
            Global.LimpiarControles(this);                                                
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
