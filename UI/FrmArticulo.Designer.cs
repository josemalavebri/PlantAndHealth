namespace PlantAndHealth.UI
{
    partial class FrmArticulo
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
            this.textBoxCosto = new System.Windows.Forms.TextBox();
            this.labelCosto = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxFamilia = new System.Windows.Forms.TextBox();
            this.labelFamilia = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.groupBoxInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(155, 203);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(96, 29);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(53, 203);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(96, 29);
            this.buttonGuardar.TabIndex = 5;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // groupBoxInformacion
            // 
            this.groupBoxInformacion.Controls.Add(this.labelCodigo);
            this.groupBoxInformacion.Controls.Add(this.textBoxCodigo);
            this.groupBoxInformacion.Controls.Add(this.textBoxCosto);
            this.groupBoxInformacion.Controls.Add(this.labelCosto);
            this.groupBoxInformacion.Controls.Add(this.textBoxPrecio);
            this.groupBoxInformacion.Controls.Add(this.labelPrecio);
            this.groupBoxInformacion.Controls.Add(this.textBoxFamilia);
            this.groupBoxInformacion.Controls.Add(this.labelFamilia);
            this.groupBoxInformacion.Controls.Add(this.labelNombre);
            this.groupBoxInformacion.Controls.Add(this.textBoxNombre);
            this.groupBoxInformacion.Location = new System.Drawing.Point(11, 14);
            this.groupBoxInformacion.Name = "groupBoxInformacion";
            this.groupBoxInformacion.Size = new System.Drawing.Size(260, 181);
            this.groupBoxInformacion.TabIndex = 15;
            this.groupBoxInformacion.TabStop = false;
            this.groupBoxInformacion.Text = "Información";
            // 
            // textBoxCosto
            // 
            this.textBoxCosto.Location = new System.Drawing.Point(63, 143);
            this.textBoxCosto.Name = "textBoxCosto";
            this.textBoxCosto.Size = new System.Drawing.Size(177, 20);
            this.textBoxCosto.TabIndex = 4;
            // 
            // labelCosto
            // 
            this.labelCosto.AutoSize = true;
            this.labelCosto.Location = new System.Drawing.Point(9, 146);
            this.labelCosto.Name = "labelCosto";
            this.labelCosto.Size = new System.Drawing.Size(37, 13);
            this.labelCosto.TabIndex = 16;
            this.labelCosto.Text = "Costo:";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(63, 112);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(177, 20);
            this.textBoxPrecio.TabIndex = 3;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(9, 115);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(40, 13);
            this.labelPrecio.TabIndex = 4;
            this.labelPrecio.Text = "Precio:";
            // 
            // textBoxFamilia
            // 
            this.textBoxFamilia.Location = new System.Drawing.Point(63, 81);
            this.textBoxFamilia.Name = "textBoxFamilia";
            this.textBoxFamilia.Size = new System.Drawing.Size(177, 20);
            this.textBoxFamilia.TabIndex = 2;
            // 
            // labelFamilia
            // 
            this.labelFamilia.AutoSize = true;
            this.labelFamilia.Location = new System.Drawing.Point(9, 84);
            this.labelFamilia.Name = "labelFamilia";
            this.labelFamilia.Size = new System.Drawing.Size(42, 13);
            this.labelFamilia.TabIndex = 2;
            this.labelFamilia.Text = "Familia:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(10, 55);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(63, 52);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(177, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(10, 26);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 18;
            this.labelCodigo.Text = "Código:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(63, 23);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(177, 20);
            this.textBoxCodigo.TabIndex = 0;
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 243);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.groupBoxInformacion);
            this.MaximizeBox = false;
            this.Name = "FrmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo artículo";
            this.Load += new System.EventHandler(this.FrmArticulo_Load);
            this.groupBoxInformacion.ResumeLayout(false);
            this.groupBoxInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.GroupBox groupBoxInformacion;
        private System.Windows.Forms.Label labelFamilia;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCosto;
        private System.Windows.Forms.Label labelCosto;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxFamilia;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
    }
}