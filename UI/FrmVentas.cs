using PlantAndHealth.BD;
using PlantAndHealth.CL;
using PlantAndHealth.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
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
        private int id;
        private int index;

        public FrmVentas()
        {
            InitializeComponent();
            /*
            comboBoxClientes.DataSource = ClienteData.ObtenerCliente();
            comboBoxClientes.DisplayMember = "Nombres";
            comboBoxClientes.ValueMember = "Numero";
            */
            comboBoxBodega.DataSource = BodegaData.ObtenerBodegas();
            comboBoxBodega.DisplayMember = "Nombres";
            comboBoxBodega.ValueMember = "Nombre";
           
            /*
            comboBoxVendedores.DataSource = VendedorData.ObtenerVendedor();
            comboBoxVendedores.DisplayMember = "Nombres";
            comboBoxVendedores.ValueMember = "Id";
             */
            comboBox_items.DataSource = ArticuloData.ObtenerArticulos();
            comboBox_items.DisplayMember = "Nombre";
            comboBox_items.ValueMember = "Id";

            txt_iva.Enabled = false;
            txt_subtotal.Enabled = false;
            txt_total.Enabled = false;
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




        private void EliminarFinal(int index)
        {
            if (index >= 0 && index < dataGridView_detalleOrden.Rows.Count)
            {
                dataGridView_detalleOrden.Rows.RemoveAt(index);
            }
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
                guardarDetalleVenta();
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


        private string generacionDocumento()
        {
            id++;
            return ""+ "FAC00584U" + id;
        }

        private void guardarDetalleVenta()
        {
            DetalleVenta detalleVenta = new DetalleVenta();

            foreach (DataGridViewRow row in dataGridView_detalleOrden.Rows)
            {
                // Asegúrate de que la fila no es una fila nueva (en blanco)
                if (!row.IsNewRow)
                {
                    detalleVenta.Documento = generacionDocumento();
                    detalleVenta.CodigoProducto = row.Cells["Id"].Value.ToString();
                    detalleVenta.PrecioUnitario = double.Parse(row.Cells["Precio"].Value.ToString());
                    detalleVenta.Cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString());
                    detalleVenta.Total = double.Parse(row.Cells["Total"].Value.ToString());
                }
            }


            DetalleVentaData.AñadirDetalleVenta(detalleVenta);

        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            Articulo articulo = (Articulo)comboBox_items.SelectedItem;
            articulos.Add(articulo);
            int cantidad = int.Parse(txt_cantidad.Text);
            cargarGridDetalleVentas(articulos, cantidad);


        }

        private void cargarGridDetalleVentas(List<Articulo> articulos, int cantidad)
        {
            dataGridView_detalleOrden.Rows.Clear();

            string descripcion = "";
            foreach (var articulo in articulos)
            {
                double total = cantidad * articulo.PrecioUnitario;
                descripcion = "" +articulo.Nombre+" - " +articulo.Familia;
                dataGridView_detalleOrden.Rows.Add(descripcion, articulo.PrecioUnitario.ToString(), cantidad,total);
            }

            calcularPrecios();
        }

        private void calcularPrecios()
        {
            double total = 0;

            validarFormatoCampos();
            foreach (DataGridViewRow row in dataGridView_detalleOrden.Rows)
            {
                // Asegúrate de que la fila no es una fila nueva (en blanco)
                if (!row.IsNewRow)
                {
                    // Supongamos que las columnas de precio unitario y cantidad son "PrecioUnitario" y "Cantidad"
                    double precioUnitario;
                    int cantidad;

                    if (double.TryParse(row.Cells["Precio"].Value?.ToString(), out precioUnitario) &&
                        int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out cantidad))
                    {
                        total += precioUnitario * cantidad;
                    }
                }
            }

            txt_subtotal.Text = total.ToString();
            double iva = ((total * 0.14));
            txt_iva.Text = iva.ToString();
            total = total + iva;
            txt_total.Text = total.ToString();
        }

        private bool validarFormatoCampos()
        {
            bool textValidaciones = ValidarFormatoForms.validarTexts(txt_cantidad,txt_iva,txt_subtotal,txt_total);
            bool comboValidaciones = ValidarFormatoForms.validarComboBox(comboBoxVendedores,comboBoxClientes,comboBox_items,comboBoxBodega);
            return textValidaciones && comboValidaciones;


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_detalleOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            EliminarFinal(index);
            articulos.RemoveAt(index);
            calcularPrecios();


        }
    }

}
