using PlantAndHealth.BD;
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
    public partial class FrmComuna : Form
    {
        private Comuna comuna = new Comuna();
        public FrmComuna()
        {
            InitializeComponent();
            comboBoxProvincias.DataSource = ProvinciaData.ObtenerProvincias();
            comboBoxProvincias.DisplayMember = "Nombre";
            comboBoxProvincias.ValueMember = "Id";
            Global.LimpiarControles(this);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (validarFormatoCampos())
                {
                    comuna.Nombre = textBoxNombre.Text;
                    comuna.Provincia = (Provincia)comboBoxProvincias.SelectedItem;

                    ComunaData.AñadirComuna(comuna);
                    MessageBox.Show("Comuna almacenada correctamente...");
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
            bool comboValidaciones = ValidarFormatoForms.validarComboBox(comboBoxProvincias);
            return textValidaciones && comboValidaciones;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBoxInformacion_Enter(object sender, EventArgs e)
        {

        }

        private void FrmComuna_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)delegate
            {
                textBoxNombre.Select();
            });
        }
    }
}
