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
    public partial class FrmArticulo : Form
    {
        private Articulo articulo=new Articulo();
        public FrmArticulo()
        {
            InitializeComponent();
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
                    articulo.Id = textBoxCodigo.Text;
                    articulo.Nombre = textBoxNombre.Text;
                    articulo.Familia = textBoxFamilia.Text;
                    articulo.PrecioUnitario = double.Parse(textBoxPrecio.Text);
                    articulo.Costo = double.Parse(textBoxCosto.Text);

                    //Almacenamiento
                    //Global.ArticuloAlmacen.AñadirArticulo(articulo);
                    //Global.plantAndHealth.Articulo.AñadirArticulo(articulo);
                    ArticuloData.AñadirArticulo(articulo);
                    MessageBox.Show("Articulo almacenado correctamente...");
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
            bool textValidaciones = ValidarFormatoForms.validarTexts(textBoxNombre,textBoxCodigo,textBoxFamilia);
            bool numberValidaciones = ValidarFormatoForms.validarNumbers(textBoxCosto, textBoxPrecio);
            return textValidaciones && numberValidaciones;
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            // Usar BeginInvoke para asegurarse de que el TextBoxNombre tenga el foco después de que el formulario se haya cargado
            this.BeginInvoke((Action)delegate
            {
                textBoxCodigo.Select();
            });
        }
    }
}
