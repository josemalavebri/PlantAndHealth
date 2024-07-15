namespace PlantAndHealth.UI
{
    partial class FrmVendedor
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
            this.comboBoxCapacitacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.labelEstadoCivil = new System.Windows.Forms.Label();
            this.textBoxHorasCapacitacion = new System.Windows.Forms.TextBox();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.groupBoxInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(155, 172);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(96, 29);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(53, 172);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(96, 29);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // groupBoxInformacion
            // 
            this.groupBoxInformacion.Controls.Add(this.comboBoxCapacitacion);
            this.groupBoxInformacion.Controls.Add(this.label2);
            this.groupBoxInformacion.Controls.Add(this.textBoxNombres);
            this.groupBoxInformacion.Controls.Add(this.labelEstadoCivil);
            this.groupBoxInformacion.Controls.Add(this.textBoxHorasCapacitacion);
            this.groupBoxInformacion.Controls.Add(this.labelEdad);
            this.groupBoxInformacion.Controls.Add(this.labelApellido);
            this.groupBoxInformacion.Controls.Add(this.textBoxApellidos);
            this.groupBoxInformacion.Location = new System.Drawing.Point(11, 10);
            this.groupBoxInformacion.Name = "groupBoxInformacion";
            this.groupBoxInformacion.Size = new System.Drawing.Size(260, 153);
            this.groupBoxInformacion.TabIndex = 21;
            this.groupBoxInformacion.TabStop = false;
            this.groupBoxInformacion.Text = "Información";
            // 
            // comboBoxCapacitacion
            // 
            this.comboBoxCapacitacion.FormattingEnabled = true;
            this.comboBoxCapacitacion.Items.AddRange(new object[] {
            "Capacitación Semipresencial",
            "Capacitación Online",
            "Capacitación En Sucursal",
            "Autodidacta"});
            this.comboBoxCapacitacion.Location = new System.Drawing.Point(76, 83);
            this.comboBoxCapacitacion.Name = "comboBoxCapacitacion";
            this.comboBoxCapacitacion.Size = new System.Drawing.Size(173, 21);
            this.comboBoxCapacitacion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre:";
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(76, 24);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(177, 20);
            this.textBoxNombres.TabIndex = 0;
            // 
            // labelEstadoCivil
            // 
            this.labelEstadoCivil.AutoSize = true;
            this.labelEstadoCivil.Location = new System.Drawing.Point(3, 85);
            this.labelEstadoCivil.Name = "labelEstadoCivil";
            this.labelEstadoCivil.Size = new System.Drawing.Size(72, 13);
            this.labelEstadoCivil.TabIndex = 4;
            this.labelEstadoCivil.Text = "Capacitación:";
            // 
            // textBoxHorasCapacitacion
            // 
            this.textBoxHorasCapacitacion.Location = new System.Drawing.Point(72, 114);
            this.textBoxHorasCapacitacion.Name = "textBoxHorasCapacitacion";
            this.textBoxHorasCapacitacion.Size = new System.Drawing.Size(177, 20);
            this.textBoxHorasCapacitacion.TabIndex = 3;
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(1, 117);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(38, 13);
            this.labelEdad.TabIndex = 2;
            this.labelEdad.Text = "Horas:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(6, 54);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(47, 13);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido:";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(76, 51);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(177, 20);
            this.textBoxApellidos.TabIndex = 1;
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 212);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.groupBoxInformacion);
            this.MaximizeBox = false;
            this.Name = "FrmVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo vendedor";
            this.Load += new System.EventHandler(this.FrmVendedor_Load);
            this.groupBoxInformacion.ResumeLayout(false);
            this.groupBoxInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.GroupBox groupBoxInformacion;
        private System.Windows.Forms.ComboBox comboBoxCapacitacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.Label labelEstadoCivil;
        private System.Windows.Forms.TextBox textBoxHorasCapacitacion;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxApellidos;
    }
}