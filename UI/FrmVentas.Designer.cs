namespace PlantAndHealth.UI
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox_itemCantidad = new System.Windows.Forms.GroupBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_agregar = new System.Windows.Forms.Button();
            this.comboBox_items = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox_detalleOrden = new System.Windows.Forms.GroupBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.dataGridView_detalleOrden = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_informacion = new System.Windows.Forms.GroupBox();
            this.comboBoxBodega = new System.Windows.Forms.ComboBox();
            this.lbl_vendedores = new System.Windows.Forms.Label();
            this.comboBoxVendedores = new System.Windows.Forms.ComboBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.lbl_nombres = new System.Windows.Forms.Label();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.lbl_residencia = new System.Windows.Forms.Label();
            this.lbl_clientes = new System.Windows.Forms.Label();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.groupBox_itemCantidad.SuspendLayout();
            this.groupBox_detalleOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detalleOrden)).BeginInit();
            this.groupBox_informacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_itemCantidad
            // 
            this.groupBox_itemCantidad.Controls.Add(this.txt_cantidad);
            this.groupBox_itemCantidad.Controls.Add(this.button_eliminar);
            this.groupBox_itemCantidad.Controls.Add(this.button_agregar);
            this.groupBox_itemCantidad.Controls.Add(this.comboBox_items);
            this.groupBox_itemCantidad.Location = new System.Drawing.Point(15, 176);
            this.groupBox_itemCantidad.Name = "groupBox_itemCantidad";
            this.groupBox_itemCantidad.Size = new System.Drawing.Size(552, 68);
            this.groupBox_itemCantidad.TabIndex = 16;
            this.groupBox_itemCantidad.TabStop = false;
            this.groupBox_itemCantidad.Text = "Seleccione un ítem e indique la cantidad";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(369, 27);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(68, 20);
            this.txt_cantidad.TabIndex = 7;
            // 
            // button_eliminar
            // 
            this.button_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("button_eliminar.Image")));
            this.button_eliminar.Location = new System.Drawing.Point(492, 16);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(47, 40);
            this.button_eliminar.TabIndex = 9;
            this.button_eliminar.UseVisualStyleBackColor = true;
            // 
            // button_agregar
            // 
            this.button_agregar.Image = ((System.Drawing.Image)(resources.GetObject("button_agregar.Image")));
            this.button_agregar.Location = new System.Drawing.Point(443, 16);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(47, 40);
            this.button_agregar.TabIndex = 8;
            this.button_agregar.UseVisualStyleBackColor = true;
            // 
            // comboBox_items
            // 
            this.comboBox_items.FormattingEnabled = true;
            this.comboBox_items.Location = new System.Drawing.Point(13, 27);
            this.comboBox_items.Name = "comboBox_items";
            this.comboBox_items.Size = new System.Drawing.Size(350, 21);
            this.comboBox_items.TabIndex = 6;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(458, 489);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(108, 33);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(344, 489);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(108, 33);
            this.btn_guardar.TabIndex = 15;
            this.btn_guardar.Text = "&Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // groupBox_detalleOrden
            // 
            this.groupBox_detalleOrden.Controls.Add(this.txt_total);
            this.groupBox_detalleOrden.Controls.Add(this.txt_iva);
            this.groupBox_detalleOrden.Controls.Add(this.txt_subtotal);
            this.groupBox_detalleOrden.Controls.Add(this.lbl_total);
            this.groupBox_detalleOrden.Controls.Add(this.lbl_iva);
            this.groupBox_detalleOrden.Controls.Add(this.lbl_subtotal);
            this.groupBox_detalleOrden.Controls.Add(this.dataGridView_detalleOrden);
            this.groupBox_detalleOrden.Location = new System.Drawing.Point(15, 242);
            this.groupBox_detalleOrden.Name = "groupBox_detalleOrden";
            this.groupBox_detalleOrden.Size = new System.Drawing.Size(552, 243);
            this.groupBox_detalleOrden.TabIndex = 14;
            this.groupBox_detalleOrden.TabStop = false;
            this.groupBox_detalleOrden.Text = "Detalle de órden";
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.Window;
            this.txt_total.Location = new System.Drawing.Point(438, 216);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(102, 20);
            this.txt_total.TabIndex = 19;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_iva
            // 
            this.txt_iva.BackColor = System.Drawing.SystemColors.Window;
            this.txt_iva.Location = new System.Drawing.Point(437, 190);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.ReadOnly = true;
            this.txt_iva.Size = new System.Drawing.Size(102, 20);
            this.txt_iva.TabIndex = 18;
            this.txt_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.BackColor = System.Drawing.SystemColors.Window;
            this.txt_subtotal.Location = new System.Drawing.Point(437, 164);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.ReadOnly = true;
            this.txt_subtotal.Size = new System.Drawing.Size(102, 20);
            this.txt_subtotal.TabIndex = 17;
            this.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(366, 215);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(34, 13);
            this.lbl_total.TabIndex = 16;
            this.lbl_total.Text = "Total:";
            // 
            // lbl_iva
            // 
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.Location = new System.Drawing.Point(366, 193);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(27, 13);
            this.lbl_iva.TabIndex = 2;
            this.lbl_iva.Text = "IVA:";
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Location = new System.Drawing.Point(366, 167);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(49, 13);
            this.lbl_subtotal.TabIndex = 1;
            this.lbl_subtotal.Text = "Subtotal:";
            // 
            // dataGridView_detalleOrden
            // 
            this.dataGridView_detalleOrden.AllowUserToAddRows = false;
            this.dataGridView_detalleOrden.AllowUserToDeleteRows = false;
            this.dataGridView_detalleOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_detalleOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.Total});
            this.dataGridView_detalleOrden.Location = new System.Drawing.Point(12, 19);
            this.dataGridView_detalleOrden.Name = "dataGridView_detalleOrden";
            this.dataGridView_detalleOrden.ReadOnly = true;
            this.dataGridView_detalleOrden.Size = new System.Drawing.Size(527, 137);
            this.dataGridView_detalleOrden.TabIndex = 10;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 250;
            // 
            // Precio
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle1;
            this.Precio.HeaderText = "Precio unitario";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 80;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 70;
            // 
            // Total
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle3;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // groupBox_informacion
            // 
            this.groupBox_informacion.Controls.Add(this.comboBoxBodega);
            this.groupBox_informacion.Controls.Add(this.lbl_vendedores);
            this.groupBox_informacion.Controls.Add(this.comboBoxVendedores);
            this.groupBox_informacion.Controls.Add(this.lbl_fecha);
            this.groupBox_informacion.Controls.Add(this.dateTimePicker_fecha);
            this.groupBox_informacion.Controls.Add(this.lbl_apellidos);
            this.groupBox_informacion.Controls.Add(this.textBoxApellidos);
            this.groupBox_informacion.Controls.Add(this.lbl_nombres);
            this.groupBox_informacion.Controls.Add(this.textBoxNombres);
            this.groupBox_informacion.Controls.Add(this.lbl_residencia);
            this.groupBox_informacion.Controls.Add(this.lbl_clientes);
            this.groupBox_informacion.Controls.Add(this.comboBoxClientes);
            this.groupBox_informacion.Controls.Add(this.lbl_codigo);
            this.groupBox_informacion.Location = new System.Drawing.Point(15, 6);
            this.groupBox_informacion.Name = "groupBox_informacion";
            this.groupBox_informacion.Size = new System.Drawing.Size(552, 163);
            this.groupBox_informacion.TabIndex = 13;
            this.groupBox_informacion.TabStop = false;
            this.groupBox_informacion.Text = "Información general";
            this.groupBox_informacion.Enter += new System.EventHandler(this.groupBox_informacion_Enter);
            // 
            // comboBoxBodega
            // 
            this.comboBoxBodega.FormattingEnabled = true;
            this.comboBoxBodega.Location = new System.Drawing.Point(359, 54);
            this.comboBoxBodega.Name = "comboBoxBodega";
            this.comboBoxBodega.Size = new System.Drawing.Size(183, 21);
            this.comboBoxBodega.TabIndex = 16;
            // 
            // lbl_vendedores
            // 
            this.lbl_vendedores.AutoSize = true;
            this.lbl_vendedores.Location = new System.Drawing.Point(27, 115);
            this.lbl_vendedores.Name = "lbl_vendedores";
            this.lbl_vendedores.Size = new System.Drawing.Size(56, 13);
            this.lbl_vendedores.TabIndex = 15;
            this.lbl_vendedores.Text = "Vendedor:";
            // 
            // comboBoxVendedores
            // 
            this.comboBoxVendedores.FormattingEnabled = true;
            this.comboBoxVendedores.Location = new System.Drawing.Point(106, 112);
            this.comboBoxVendedores.Name = "comboBoxVendedores";
            this.comboBoxVendedores.Size = new System.Drawing.Size(185, 21);
            this.comboBoxVendedores.TabIndex = 4;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(302, 115);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(40, 13);
            this.lbl_fecha.TabIndex = 13;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // dateTimePicker_fecha
            // 
            this.dateTimePicker_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_fecha.Location = new System.Drawing.Point(358, 113);
            this.dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            this.dateTimePicker_fecha.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker_fecha.TabIndex = 2;
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Location = new System.Drawing.Point(302, 86);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(52, 13);
            this.lbl_apellidos.TabIndex = 9;
            this.lbl_apellidos.Text = "Apellidos:";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxApellidos.Location = new System.Drawing.Point(358, 83);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.ReadOnly = true;
            this.textBoxApellidos.Size = new System.Drawing.Size(184, 20);
            this.textBoxApellidos.TabIndex = 8;
            // 
            // lbl_nombres
            // 
            this.lbl_nombres.AutoSize = true;
            this.lbl_nombres.Location = new System.Drawing.Point(27, 86);
            this.lbl_nombres.Name = "lbl_nombres";
            this.lbl_nombres.Size = new System.Drawing.Size(52, 13);
            this.lbl_nombres.TabIndex = 7;
            this.lbl_nombres.Text = "Nombres:";
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNombres.Location = new System.Drawing.Point(106, 82);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.ReadOnly = true;
            this.textBoxNombres.Size = new System.Drawing.Size(185, 20);
            this.textBoxNombres.TabIndex = 6;
            // 
            // lbl_residencia
            // 
            this.lbl_residencia.AutoSize = true;
            this.lbl_residencia.Location = new System.Drawing.Point(302, 58);
            this.lbl_residencia.Name = "lbl_residencia";
            this.lbl_residencia.Size = new System.Drawing.Size(47, 13);
            this.lbl_residencia.TabIndex = 5;
            this.lbl_residencia.Text = "Bodega:";
            // 
            // lbl_clientes
            // 
            this.lbl_clientes.AutoSize = true;
            this.lbl_clientes.Location = new System.Drawing.Point(28, 56);
            this.lbl_clientes.Name = "lbl_clientes";
            this.lbl_clientes.Size = new System.Drawing.Size(42, 13);
            this.lbl_clientes.TabIndex = 3;
            this.lbl_clientes.Text = "Cliente:";
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(106, 53);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(186, 21);
            this.comboBoxClientes.TabIndex = 1;
            this.comboBoxClientes.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientes_SelectedIndexChanged);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(27, 19);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(35, 25);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "N°";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 530);
            this.Controls.Add(this.groupBox_itemCantidad);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox_detalleOrden);
            this.Controls.Add(this.groupBox_informacion);
            this.Name = "FrmVentas";
            this.Text = "Nueva venta";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.groupBox_itemCantidad.ResumeLayout(false);
            this.groupBox_itemCantidad.PerformLayout();
            this.groupBox_detalleOrden.ResumeLayout(false);
            this.groupBox_detalleOrden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detalleOrden)).EndInit();
            this.groupBox_informacion.ResumeLayout(false);
            this.groupBox_informacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_itemCantidad;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.ComboBox comboBox_items;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox_detalleOrden;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.DataGridView dataGridView_detalleOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.GroupBox groupBox_informacion;
        private System.Windows.Forms.Label lbl_vendedores;
        private System.Windows.Forms.ComboBox comboBoxVendedores;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label lbl_nombres;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.Label lbl_clientes;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.ComboBox comboBoxBodega;
        private System.Windows.Forms.Label lbl_residencia;
    }
}