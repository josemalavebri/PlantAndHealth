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
    public partial class FrmSucursal : Form
    {
        private Sucursal sucursal = new Sucursal();
        public FrmSucursal()
        {
            InitializeComponent();
            //comboBoxComunas.DataSource = Global.ComunaAlmacen.ObtenerComunas();
            //comboBoxComunas.DataSource = Global.plantAndHealth.Comuna.ObtenerComunas();
            comboBoxComunas.DataSource = ComunaData.ObtenerComunas();
            comboBoxComunas.DisplayMember = "Nombre";
            comboBoxComunas.ValueMember = "Id";
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
                sucursal.Nombre = textBoxNombre.Text;
                sucursal.Comuna = (Comuna)comboBoxComunas.SelectedItem;

                //Almacenamiento
                //Global.SucursalAlmacen.AñadirSucursal(sucursal);
                //Global.plantAndHealth.Sucursal.AñadirSucursal(sucursal);
                SucursalData.AñadirSucursal(sucursal);
                MessageBox.Show("Sucursal almacenada correctamente...");
                Global.LimpiarControles(this);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmSucursal_Load(object sender, EventArgs e)
        {
            // Usar BeginInvoke para asegurarse de que el TextBoxNombre tenga el foco después de que el formulario se haya cargado
            this.BeginInvoke((Action)delegate
            {
                textBoxNombre.Select();
            });
        }
    }
}
