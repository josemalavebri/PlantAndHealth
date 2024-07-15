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

namespace PlantAndHealth.UI
{
    public partial class FrmComuna : Form
    {
        private Comuna comuna = new Comuna();
        public FrmComuna()
        {
            InitializeComponent();
            //comboBoxProvincias.DataSource = Global.ProvinciaAlmacen.ObtenerProvincias();
            //comboBoxProvincias.DataSource = Global.plantAndHealth.Provincia.ObtenerProvincias();
            //comboBoxProvincias.DataSource = ProvinciaData.ObtenerProvincias();            
            comboBoxProvincias.DataSource = ProvinciaData.ObtenerProvincias();
            comboBoxProvincias.DisplayMember = "Nombre";
            comboBoxProvincias.ValueMember = "Id";
            Global.LimpiarControles(this);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                comuna.Nombre = textBoxNombre.Text;
                comuna.Provincia = (Provincia)comboBoxProvincias.SelectedItem;

                //Almacenamiento
                //Global.ComunaAlmacen.AñadirComuna(comuna);
                //Global.plantAndHealth.Comuna.AñadirComuna(comuna);
                ComunaData.AñadirComuna(comuna);
                MessageBox.Show("Comuna almacenada correctamente...");
                Global.LimpiarControles(this);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            // Usar BeginInvoke para asegurarse de que el TextBoxNombre tenga el foco después de que el formulario se haya cargado
            this.BeginInvoke((Action)delegate
            {
                textBoxNombre.Select();
            });
        }
    }
}
