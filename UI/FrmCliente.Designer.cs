namespace PlantAndHealth.UI
{
    partial class FrmCliente
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
            this.textBoxResidencia = new System.Windows.Forms.TextBox();
            this.labelCosto = new System.Windows.Forms.Label();
            this.labelEstadoCivil = new System.Windows.Forms.Label();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.textBoxOrigen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.groupBoxInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(155, 257);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(96, 29);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(53, 257);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(96, 29);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // groupBoxInformacion
            // 
            this.groupBoxInformacion.Controls.Add(this.comboBoxEstadoCivil);
            this.groupBoxInformacion.Controls.Add(this.textBoxOrigen);
            this.groupBoxInformacion.Controls.Add(this.label3);
            this.groupBoxInformacion.Controls.Add(this.label2);
            this.groupBoxInformacion.Controls.Add(this.label1);
            this.groupBoxInformacion.Controls.Add(this.textBoxNombres);
            this.groupBoxInformacion.Controls.Add(this.textBoxCodigo);
            this.groupBoxInformacion.Controls.Add(this.textBoxResidencia);
            this.groupBoxInformacion.Controls.Add(this.labelCosto);
            this.groupBoxInformacion.Controls.Add(this.labelEstadoCivil);
            this.groupBoxInformacion.Controls.Add(this.textBoxEdad);
            this.groupBoxInformacion.Controls.Add(this.labelEdad);
            this.groupBoxInformacion.Controls.Add(this.labelApellido);
            this.groupBoxInformacion.Controls.Add(this.textBoxApellidos);
            this.groupBoxInformacion.Location = new System.Drawing.Point(11, 12);
            this.groupBoxInformacion.Name = "groupBoxInformacion";
            this.groupBoxInformacion.Size = new System.Drawing.Size(260, 239);
            this.groupBoxInformacion.TabIndex = 18;
            this.groupBoxInformacion.TabStop = false;
            this.groupBoxInformacion.Text = "Información";
            this.groupBoxInformacion.Enter += new System.EventHandler(this.groupBoxInformacion_Enter);
            // 
            // textBoxResidencia
            // 
            this.textBoxResidencia.Location = new System.Drawing.Point(63, 168);
            this.textBoxResidencia.Name = "textBoxResidencia";
            this.textBoxResidencia.Size = new System.Drawing.Size(177, 20);
            this.textBoxResidencia.TabIndex = 5;
            // 
            // labelCosto
            // 
            this.labelCosto.AutoSize = true;
            this.labelCosto.Location = new System.Drawing.Point(3, 171);
            this.labelCosto.Name = "labelCosto";
            this.labelCosto.Size = new System.Drawing.Size(63, 13);
            this.labelCosto.TabIndex = 16;
            this.labelCosto.Text = "Residencia:";
            // 
            // labelEstadoCivil
            // 
            this.labelEstadoCivil.AutoSize = true;
            this.labelEstadoCivil.Location = new System.Drawing.Point(5, 139);
            this.labelEstadoCivil.Name = "labelEstadoCivil";
            this.labelEstadoCivil.Size = new System.Drawing.Size(50, 13);
            this.labelEstadoCivil.TabIndex = 4;
            this.labelEstadoCivil.Text = "Est. Civil:";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(63, 105);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(177, 20);
            this.textBoxEdad.TabIndex = 3;
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(5, 108);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(35, 13);
            this.labelEdad.TabIndex = 2;
            this.labelEdad.Text = "Edad:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(6, 79);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(47, 13);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido:";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(63, 76);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(177, 20);
            this.textBoxApellidos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Código:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(66, 20);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(177, 20);
            this.textBoxCodigo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre:";
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(63, 49);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(177, 20);
            this.textBoxNombres.TabIndex = 1;
            // 
            // textBoxOrigen
            // 
            this.textBoxOrigen.Location = new System.Drawing.Point(62, 198);
            this.textBoxOrigen.Name = "textBoxOrigen";
            this.textBoxOrigen.Size = new System.Drawing.Size(177, 20);
            this.textBoxOrigen.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Origen:";
            // 
            // comboBoxEstadoCivil
            // 
            this.comboBoxEstadoCivil.FormattingEnabled = true;
            this.comboBoxEstadoCivil.Items.AddRange(new object[] {
            "Casado",
            "Soltero",
            "Divorciado",
            "Viudo"});
            this.comboBoxEstadoCivil.Location = new System.Drawing.Point(65, 137);
            this.comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
            this.comboBoxEstadoCivil.Size = new System.Drawing.Size(173, 21);
            this.comboBoxEstadoCivil.TabIndex = 4;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 294);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.groupBoxInformacion);
            this.MaximizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.groupBoxInformacion.ResumeLayout(false);
            this.groupBoxInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.GroupBox groupBoxInformacion;
        private System.Windows.Forms.TextBox textBoxResidencia;
        private System.Windows.Forms.Label labelCosto;
        private System.Windows.Forms.Label labelEstadoCivil;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEstadoCivil;
    }
}