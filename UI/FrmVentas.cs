using PlantAndHealth.BD;
using PlantAndHealth.CL;
using PlantAndHealth.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PlantAndHealth.UI
{
    public partial class FrmVentas : Form
    {
        Ventas venta = new Ventas();
        List<Articulo> articulos = new List<Articulo>();
        public FrmVentas()
        {
            InitializeComponent();
            /*
            comboBoxClientes.DataSource = ClienteData.ObtenerCliente();
            comboBoxClientes.DisplayMember = "Nombres";
            comboBoxClientes.ValueMember = "Numero";

            comboBoxBodega.DataSource = BodegaData.ObtenerBodegas();
            comboBoxBodega.DisplayMember = "Nombres";
            comboBoxBodega.ValueMember = "Id";
           

            comboBoxVendedores.DataSource = VendedorData.ObtenerVendedor();
            comboBoxVendedores.DisplayMember = "Nombres";
            comboBoxVendedores.ValueMember = "Id";
             */
            comboBox_items.DataSource = ArticuloData.ObtenerArticulos();
            comboBox_items.DisplayMember = "Nombre";
            comboBox_items.ValueMember = "Id";
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)comboBoxClientes.SelectedItem;
            if (clienteSeleccionado != null)
            {
                textBoxNombres.Text = clienteSeleccionado.Nombres;
                textBoxApellidos.Text = clienteSeleccionado.Apellidos;
            }
        }

        private void groupBox_informacion_Enter(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarFormatoCampos())
            {
                venta.Documento = comboBox_items.SelectedItem.ToString();
                venta.Fecha = DateTime.Parse(dateTimePicker_fecha.Text);
                venta.Cliente = (Cliente)comboBoxClientes.SelectedItem;
                venta.TipoDocumento = "FACTURA";
                venta.Vendedor = (Vendedor)comboBoxVendedores.SelectedItem;
                venta.TotalNeto = double.Parse(txt_subtotal.Text);
                venta.Impuesto = double.Parse(txt_iva.Text);
                venta.TotalDocumento = double.Parse(txt_total.Text);
                venta.Bodega = (Bodega)comboBoxBodega.SelectedItem;

                VentaData.AñadirVenta(venta);

                MessageBox.Show("Comuna almacenada correctamente...");
                Global.LimpiarControles(this);
                this.Close();

                //  AÑADIR DETALLE VENTA
            }
            else
            {
                MessageBox.Show("Campos con formato incorrecto");
            }

        }

        private bool validarFormatoCampos()
        {
            /*
            bool textValidaciones = ValidarFormatoForms.validarTexts(textBoxNombres, textBoxApellidos);
            bool numberValidaciones = ValidarFormatoForms.validarNumbers(textBoxHorasCapacitacion);
            bool comboValidaciones = ValidarFormatoForms.validarComboBox(comboBoxCapacitacion);
            return textValidaciones && comboValidaciones;
            */
            return true;

        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            Articulo articulo = (Articulo)comboBox_items.SelectedItem;
            articulos.Add(articulo);
            cargarGridDetalleVentas(articulos);

        }

        private void cargarGridDetalleVentas(int rowIndex)
        {

            if (rowIndex < 0 || rowIndex >= dataGridView_detalleOrden.Rows.Count) return;
            var row = dataGridView_detalleOrden.Rows[rowIndex];
            if (row.Cells["Precio"].Value != null && row.Cells
            ["Cantidad"].Value != null)
            {
                decimal precio = Convert.ToDecimal(row.Cells
                ["Precio"].Value);
                int cantidad = Convert.ToInt32(row.Cells
                ["Cantidad"].Value);
                row.Cells["Total"].Value = precio * cantidad;
            }


        }
    }
}
