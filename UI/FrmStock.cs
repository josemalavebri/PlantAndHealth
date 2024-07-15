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
    public partial class FrmStock : Form
    {

        private Stock stock = new Stock();

        public FrmStock()
        {
            InitializeComponent();
            //comboBoxBodegas.DataSource = Global.BodegaAlmacen.ObtenerBodegas();            
            comboBoxBodegas.DataSource = BodegaData.ObtenerBodegas();
            comboBoxBodegas.DisplayMember = "Nombre";
            comboBoxBodegas.ValueMember = "Id";

            //comboBoxArticulos.DataSource = Global.ArticuloAlmacen.ObtenerArticulos();
            comboBoxArticulos.DataSource = ArticuloData.ObtenerArticulos();
            comboBoxArticulos.DisplayMember = "Nombre";
            comboBoxArticulos.ValueMember = "Id";
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
                    stock.Bodega = (Bodega)comboBoxBodegas.SelectedItem;
                    stock.Articulo = (Articulo)comboBoxArticulos.SelectedItem;
                    stock.Cantidad = int.Parse(textBoxCantidad.Text);
                    StockData.AñadirStock(stock);
                    MessageBox.Show("Stock almacenado correctamente...");
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
            bool numberValidaciones = ValidarFormatoForms.validarNumbers(textBoxCantidad);
            bool comboValidaciones = ValidarFormatoForms.validarComboBox(comboBoxBodegas,comboBoxArticulos);
            return numberValidaciones && comboValidaciones;
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            // Usar BeginInvoke para asegurarse de que el TextBoxNombre tenga el foco después de que el formulario se haya cargado
            this.BeginInvoke((Action)delegate
            {
                comboBoxBodegas.Select();
            });
        }
    }
}
