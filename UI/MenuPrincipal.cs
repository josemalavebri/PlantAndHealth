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
    public partial class MenuPrincipal : Form
    {
        //private int childFormNumber = 0;
        // https://www.flaticon.es/resultados?word=ciudad

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void NuevaRegion(object sender, EventArgs e)
        {
            Form childForm = new FrmRegion();
            childForm.MdiParent = this;
            //childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void NuevaProvincia(object sender, EventArgs e)
        {
            Form childForm = new FrmProvincia();
            childForm.MdiParent = this;
            //childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void NuevaComuna(object sender, EventArgs e)
        {
            Form childForm = new FrmComuna();
            childForm.MdiParent = this;
            //childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void NuevaSucursal(object sender, EventArgs e)
        {
            Form childForm = new FrmSucursal();
            childForm.MdiParent = this;
            //childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void NuevaBodega(object sender, EventArgs e)
        {
            Form childForm = new FrmBodega();
            childForm.MdiParent = this;
            //childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void NuevoArticulo(object sender, EventArgs e)
        {
            Form childForm = new FrmArticulo();
            childForm.MdiParent = this;
            //childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void NuevoStock(object sender, EventArgs e)
        {
            Form childForm = new FrmStock();
            childForm.MdiParent = this;
            //childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void NuevoCliente(object sender, EventArgs e)
        {
            Form childForm = new FrmCliente();
            childForm.MdiParent = this;
            //childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void NuevoVendedor(object sender, EventArgs e)
        {
            Form childForm = new FrmVendedor();
            childForm.MdiParent = this;
            //childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void NuevaVenta(object sender, EventArgs e)
        {
            Form childForm = new FrmVentas();
            childForm.MdiParent = this;
            //childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }
    }
}
