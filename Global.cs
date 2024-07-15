using PlantAndHealth.AL;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantAndHealth
{
    public static class Global
    {
        //public static PlantAndHealthAL plantAndHealth = new PlantAndHealthAL();
        public static RegionAlmacen RegionAlmacen = new RegionAlmacen();
        public static ProvinciaAlmacen ProvinciaAlmacen = new ProvinciaAlmacen();
        public static ComunaAlmacen ComunaAlmacen = new ComunaAlmacen();
        public static BodegaAlmacen BodegaAlmacen = new BodegaAlmacen();
        public static ArticuloAlmacen ArticuloAlmacen = new ArticuloAlmacen();
        public static SucursalAlmacen SucursalAlmacen = new SucursalAlmacen();
        public static StockAlmacen StockAlmacen = new StockAlmacen();
        public static ClienteAlmacen ClienteAlmacen = new ClienteAlmacen();
        public static VendedorAlmacen VendedorAlmacen = new VendedorAlmacen();
        public static int secRegion = 1;
        public static int secProvincia = 1;
        public static int secVentas = 1;
        
        public static int GeneraSecuenciaRegion()
        {            
          return secRegion++;                                
        }

        public static int GeneraSecuenciaProvincia()
        {
            return secProvincia++;
        }

        public static int GeneraSecuenciaVentas()
        {
            return secVentas++;
        }

        public static void LimpiarControles(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
                else if (control is ListBox)
                {
                    ((ListBox)control).ClearSelected();
                }
                else if (control is RichTextBox)
                {
                    ((RichTextBox)control).Text = string.Empty;
                }
                else if (control is DataGridView)
                {
                    ((DataGridView)control).Rows.Clear();
                }
                // Llamada recursiva para limpiar controles dentro de contenedores
                if (control.HasChildren)
                {
                    LimpiarControles(control);
                }
            }
        }
    }
}
