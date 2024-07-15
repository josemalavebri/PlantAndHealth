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

namespace PlantAndHealth.UI
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            try
            {
                cliente.Id = textBoxCodigo.Text;
                cliente.Nombres = textBoxNombres.Text;
                cliente.Apellidos = textBoxApellidos.Text;
                cliente.Edad = int.Parse(textBoxEdad.Text);
                cliente.EstadoCivil = (String)comboBoxEstadoCivil.SelectedItem;
                cliente.Residencia = textBoxResidencia.Text;
                cliente.Origen=textBoxOrigen.Text;

                //Almacenamiento
                Global.ClienteAlmacen.AñadirCliente(cliente);
                MessageBox.Show("Cliente almacenado correctamente...");
                Global.LimpiarControles(this);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBoxInformacion_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // Usar BeginInvoke para asegurarse de que el TextBoxNombre tenga el foco después de que el formulario se haya cargado
            this.BeginInvoke((Action)delegate
            {
                textBoxCodigo.Select();
            });
        }
    }
}
