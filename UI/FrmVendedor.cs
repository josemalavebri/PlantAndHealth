using PlantAndHealth.CL;
using PlantAndHealth.Validaciones;
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
    public partial class FrmVendedor : Form
    {
        public FrmVendedor()
        {
            InitializeComponent();            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor();
            try
            {
                if (validarFormatoCampos())
                {
                    vendedor.Nombres = textBoxNombres.Text;
                    vendedor.Apellidos = textBoxApellidos.Text;
                    vendedor.TipoCapacitacion = (String)comboBoxCapacitacion.SelectedItem;
                    vendedor.HorasCapacitacion = int.Parse(textBoxHorasCapacitacion.Text);
                    Global.VendedorAlmacen.AñadirVendedor(vendedor);
                    MessageBox.Show("Vendedor almacenado correctamente...");
                    Global.LimpiarControles(this);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Campos con formato incorrecto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validarFormatoCampos()
        {
            bool textValidaciones = ValidarFormatoForms.validarTexts(textBoxNombres, textBoxApellidos);
            bool numberValidaciones = ValidarFormatoForms.validarNumbers(textBoxHorasCapacitacion);
            bool comboValidaciones = ValidarFormatoForms.validarComboBox(comboBoxCapacitacion);

            return textValidaciones && comboValidaciones;
        }

        private void FrmVendedor_Load(object sender, EventArgs e)
        {
            // Usar BeginInvoke para asegurarse de que el TextBoxNombre tenga el foco después de que el formulario se haya cargado
            this.BeginInvoke((Action)delegate
            {
                textBoxNombres.Select();
            });
        }
    }
}
