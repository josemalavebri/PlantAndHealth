using PlantAndHealth.BD;
using PlantAndHealth.CL;
using PlantAndHealth.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantAndHealth.UI
{
    public partial class FrmProvincia : Form
    {
        Provincia provincia = new Provincia();
        public FrmProvincia()
        {
            InitializeComponent();
            //comboBoxRegiones.DataSource = Global.RegionAlmacen.ObtenerRegiones();
            //comboBoxRegiones.DataSource = Global.plantAndHealth.Region.ObtenerRegiones();
            comboBoxRegiones.DataSource = RegionData.ObtenerRegiones();
            comboBoxRegiones.DisplayMember = "Nombre";
            comboBoxRegiones.ValueMember = "Id";
            Global.LimpiarControles(this);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarFormatoCampos())
                {
                    provincia.Id = Global.GeneraSecuenciaProvincia();
                    provincia.Nombre = textBoxNombre.Text;
                    provincia.Region = (Region)comboBoxRegiones.SelectedItem;

                    ProvinciaData.AñadirProvincia(provincia);
                    MessageBox.Show("Provincia almacenada correctamente...");
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
            bool textValidaciones = ValidarFormatoForms.validarTexts(textBoxNombre);
            bool comboValidaciones = ValidarFormatoForms.validarComboBox(comboBoxRegiones);

            return textValidaciones && comboValidaciones;

        }

        private void FrmProvincia_Load(object sender, EventArgs e)
        {
            // Usar BeginInvoke para asegurarse de que el TextBoxNombre tenga el foco después de que el formulario se haya cargado
            this.BeginInvoke((Action)delegate
            {
                textBoxNombre.Select();
            });
        }
    }
}
