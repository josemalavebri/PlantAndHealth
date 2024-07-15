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
    public partial class FrmBodega : Form
    {
        private Bodega bodega=new Bodega();
        public FrmBodega()
        {
            InitializeComponent();
            //comboBoxSucursales.DataSource = Global.SucursalAlmacen.ObtenerSucursales();
            //comboBoxSucursales.DataSource = Global.plantAndHealth.Sucursal.ObtenerSucursales();
            comboBoxSucursales.DataSource = SucursalData.ObtenerSucursales();
            comboBoxSucursales.DisplayMember = "Nombre";
            comboBoxSucursales.ValueMember = "Id";
            Global.LimpiarControles(this);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bodega.Nombre = textBoxNombre.Text;
                bodega.Sucursal = (Sucursal)comboBoxSucursales.SelectedItem;

                //Almacenamiento
                //Global.BodegaAlmacen.AñadirBodega(bodega);
                //Global.plantAndHealth.Bodega.AñadirBodega(bodega);
                BodegaData.AñadirBodega(bodega);
                MessageBox.Show("Bodega almacenada correctamente...");
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

        private void FrmBodega_Load(object sender, EventArgs e)
        {
            // Usar BeginInvoke para asegurarse de que el TextBoxNombre tenga el foco después de que el formulario se haya cargado
            this.BeginInvoke((Action)delegate
            {
                textBoxNombre.Select();
            });
        }
    }
}
