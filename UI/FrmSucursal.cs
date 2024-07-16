﻿using PlantAndHealth.BD;
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
    public partial class FrmSucursal : Form
    {
        private Sucursal sucursal = new Sucursal();
        public FrmSucursal()
        {
            InitializeComponent();
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
                if (validarFormatoCampos())
                {
                    sucursal.Nombre = textBoxNombre.Text;
                    sucursal.Comuna = (Comuna)comboBoxComunas.SelectedItem;
                    SucursalData.AñadirSucursal(sucursal);
                    MessageBox.Show("Sucursal almacenada correctamente...");
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
            bool textValidaciones = ValidarFormatoForms.validarTexts(textBoxNombre);
            bool comboValidaciones = ValidarFormatoForms.validarComboBox(comboBoxComunas);
            return textValidaciones && comboValidaciones;
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
