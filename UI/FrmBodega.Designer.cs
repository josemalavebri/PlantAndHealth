namespace PlantAndHealth.UI
{
    partial class FrmBodega
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.groupBoxInformacion = new System.Windows.Forms.GroupBox();
            this.comboBoxSucursales = new System.Windows.Forms.ComboBox();
            this.labelSucursal = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.groupBoxInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(155, 122);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(96, 29);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(53, 122);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(96, 29);
            this.buttonGuardar.TabIndex = 2;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // groupBoxInformacion
            // 
            this.groupBoxInformacion.Controls.Add(this.comboBoxSucursales);
            this.groupBoxInformacion.Controls.Add(this.labelSucursal);
            this.groupBoxInformacion.Controls.Add(this.labelNombre);
            this.groupBoxInformacion.Controls.Add(this.textBoxNombre);
            this.groupBoxInformacion.Location = new System.Drawing.Point(11, 14);
            this.groupBoxInformacion.Name = "groupBoxInformacion";
            this.groupBoxInformacion.Size = new System.Drawing.Size(260, 100);
            this.groupBoxInformacion.TabIndex = 12;
            this.groupBoxInformacion.TabStop = false;
            this.groupBoxInformacion.Text = "Información";
            this.groupBoxInformacion.Enter += new System.EventHandler(this.groupBoxInformacion_Enter);
            // 
            // comboBoxSucursales
            // 
            this.comboBoxSucursales.FormattingEnabled = true;
            this.comboBoxSucursales.Location = new System.Drawing.Point(60, 59);
            this.comboBoxSucursales.Name = "comboBoxSucursales";
            this.comboBoxSucursales.Size = new System.Drawing.Size(180, 21);
            this.comboBoxSucursales.TabIndex = 1;
            // 
            // labelSucursal
            // 
            this.labelSucursal.AutoSize = true;
            this.labelSucursal.Location = new System.Drawing.Point(9, 62);
            this.labelSucursal.Name = "labelSucursal";
            this.labelSucursal.Size = new System.Drawing.Size(51, 13);
            this.labelSucursal.TabIndex = 2;
            this.labelSucursal.Text = "Sucursal:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(10, 33);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(63, 30);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(177, 20);
            this.textBoxNombre.TabIndex = 0;
            // 
            // FrmBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 164);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.groupBoxInformacion);
            this.MaximizeBox = false;
            this.Name = "FrmBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva bodega";
            this.Load += new System.EventHandler(this.FrmBodega_Load);
            this.groupBoxInformacion.ResumeLayout(false);
            this.groupBoxInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.GroupBox groupBoxInformacion;
        private System.Windows.Forms.ComboBox comboBoxSucursales;
        private System.Windows.Forms.Label labelSucursal;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
    }
}