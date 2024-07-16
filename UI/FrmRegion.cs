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

namespace PlantAndHealth
{
    public partial class FrmRegion : Form
    {
        public FrmRegion()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (validarFormatoCampos())
            {
                Region region = new Region();
                region.Id = Global.GeneraSecuenciaRegion();
                region.Nombre = textBoxNombre.Text;
                RegionData.AñadirRegion(region);
                MessageBox.Show("Region almacenada correctamente...");
                Global.LimpiarControles(this);
                this.Close();
            }
            else
            {
                MessageBox.Show("Campos con formato incorrecto");
            }
        }

        private bool validarFormatoCampos()
        {
            bool textValidaciones = ValidarFormatoForms.validarTexts(textBoxNombre);
            return textValidaciones;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
