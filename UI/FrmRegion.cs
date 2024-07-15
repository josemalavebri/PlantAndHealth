using PlantAndHealth.BD;
using PlantAndHealth.CL;
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
            Region region = new Region();
            region.Id = Global.GeneraSecuenciaRegion();
            region.Nombre = textBoxNombre.Text;

            //Almacenamiento
            //Global.RegionAlmacen.AñadirRegion(region);
            //Global.plantAndHealth.Region.AñadirRegion(region);
            
            RegionData.AñadirRegion(region);
            MessageBox.Show("Region almacenada correctamente...");
            Global.LimpiarControles(this);
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
