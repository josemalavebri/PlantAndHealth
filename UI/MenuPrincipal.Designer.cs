namespace PlantAndHealth.UI
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.parametrosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaRegion = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaProvincia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaSucursal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevaBodega = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoStock = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoVendedor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.nuevaToolStripButtonRegion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevaProvinciaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevaComunaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevaSucursalToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevaVentaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrosMenu,
            this.procesosMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // parametrosMenu
            // 
            this.parametrosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaRegion,
            this.nuevaProvincia,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.nuevaSucursal,
            this.toolStripSeparator4,
            this.nuevaBodega,
            this.nuevoArticulo,
            this.nuevoStock,
            this.nuevoCliente,
            this.nuevoVendedor,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.parametrosMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.parametrosMenu.Name = "parametrosMenu";
            this.parametrosMenu.Size = new System.Drawing.Size(104, 20);
            this.parametrosMenu.Text = "&Parametrización";
            // 
            // nuevaRegion
            // 
            this.nuevaRegion.Image = ((System.Drawing.Image)(resources.GetObject("nuevaRegion.Image")));
            this.nuevaRegion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevaRegion.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevaRegion.Name = "nuevaRegion";
            this.nuevaRegion.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevaRegion.Size = new System.Drawing.Size(182, 38);
            this.nuevaRegion.Text = "&Region";
            this.nuevaRegion.Click += new System.EventHandler(this.NuevaRegion);
            // 
            // nuevaProvincia
            // 
            this.nuevaProvincia.Image = ((System.Drawing.Image)(resources.GetObject("nuevaProvincia.Image")));
            this.nuevaProvincia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevaProvincia.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevaProvincia.Name = "nuevaProvincia";
            this.nuevaProvincia.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.nuevaProvincia.Size = new System.Drawing.Size(182, 38);
            this.nuevaProvincia.Text = "Pr&ovincia";
            this.nuevaProvincia.Click += new System.EventHandler(this.NuevaProvincia);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(182, 38);
            this.saveToolStripMenuItem.Text = "&Comuna";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.NuevaComuna);
            // 
            // nuevaSucursal
            // 
            this.nuevaSucursal.Image = ((System.Drawing.Image)(resources.GetObject("nuevaSucursal.Image")));
            this.nuevaSucursal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevaSucursal.Name = "nuevaSucursal";
            this.nuevaSucursal.Size = new System.Drawing.Size(182, 38);
            this.nuevaSucursal.Text = "&Sucursal";
            this.nuevaSucursal.Click += new System.EventHandler(this.NuevaSucursal);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(179, 6);
            // 
            // nuevaBodega
            // 
            this.nuevaBodega.Image = ((System.Drawing.Image)(resources.GetObject("nuevaBodega.Image")));
            this.nuevaBodega.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevaBodega.Name = "nuevaBodega";
            this.nuevaBodega.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.nuevaBodega.Size = new System.Drawing.Size(182, 38);
            this.nuevaBodega.Text = "&Bodega";
            this.nuevaBodega.Click += new System.EventHandler(this.NuevaBodega);
            // 
            // nuevoArticulo
            // 
            this.nuevoArticulo.Image = ((System.Drawing.Image)(resources.GetObject("nuevoArticulo.Image")));
            this.nuevoArticulo.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevoArticulo.Name = "nuevoArticulo";
            this.nuevoArticulo.Size = new System.Drawing.Size(182, 38);
            this.nuevoArticulo.Text = "&Artículo";
            this.nuevoArticulo.Click += new System.EventHandler(this.NuevoArticulo);
            // 
            // nuevoStock
            // 
            this.nuevoStock.Name = "nuevoStock";
            this.nuevoStock.Size = new System.Drawing.Size(182, 38);
            this.nuevoStock.Text = "S&tock";
            this.nuevoStock.Click += new System.EventHandler(this.NuevoStock);
            // 
            // nuevoCliente
            // 
            this.nuevoCliente.Name = "nuevoCliente";
            this.nuevoCliente.Size = new System.Drawing.Size(182, 38);
            this.nuevoCliente.Text = "Client&e";
            this.nuevoCliente.Click += new System.EventHandler(this.NuevoCliente);
            // 
            // nuevoVendedor
            // 
            this.nuevoVendedor.Name = "nuevoVendedor";
            this.nuevoVendedor.Size = new System.Drawing.Size(182, 38);
            this.nuevoVendedor.Text = "&Vendedor";
            this.nuevoVendedor.Click += new System.EventHandler(this.NuevoVendedor);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(179, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 38);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // procesosMenu
            // 
            this.procesosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVenta});
            this.procesosMenu.Name = "procesosMenu";
            this.procesosMenu.Size = new System.Drawing.Size(66, 20);
            this.procesosMenu.Text = "Proces&os";
            // 
            // nuevaVenta
            // 
            this.nuevaVenta.Image = ((System.Drawing.Image)(resources.GetObject("nuevaVenta.Image")));
            this.nuevaVenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevaVenta.Name = "nuevaVenta";
            this.nuevaVenta.Size = new System.Drawing.Size(196, 38);
            this.nuevaVenta.Text = "Vent&a";
            this.nuevaVenta.Click += new System.EventHandler(this.NuevaVenta);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(53, 20);
            this.helpMenu.Text = "Ay&uda";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripButtonRegion,
            this.toolStripSeparator7,
            this.nuevaProvinciaToolStripButton,
            this.toolStripSeparator6,
            this.nuevaComunaToolStripButton,
            this.toolStripSeparator1,
            this.nuevaSucursalToolStripButton,
            this.toolStripSeparator8,
            this.nuevaVentaToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 71);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // nuevaToolStripButtonRegion
            // 
            this.nuevaToolStripButtonRegion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevaToolStripButtonRegion.Image = ((System.Drawing.Image)(resources.GetObject("nuevaToolStripButtonRegion.Image")));
            this.nuevaToolStripButtonRegion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevaToolStripButtonRegion.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevaToolStripButtonRegion.Name = "nuevaToolStripButtonRegion";
            this.nuevaToolStripButtonRegion.Size = new System.Drawing.Size(68, 68);
            this.nuevaToolStripButtonRegion.Text = "Nuevo";
            this.nuevaToolStripButtonRegion.Click += new System.EventHandler(this.NuevaRegion);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 71);
            // 
            // nuevaProvinciaToolStripButton
            // 
            this.nuevaProvinciaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevaProvinciaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevaProvinciaToolStripButton.Image")));
            this.nuevaProvinciaToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevaProvinciaToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevaProvinciaToolStripButton.Name = "nuevaProvinciaToolStripButton";
            this.nuevaProvinciaToolStripButton.Size = new System.Drawing.Size(68, 68);
            this.nuevaProvinciaToolStripButton.Text = "Abrir";
            this.nuevaProvinciaToolStripButton.ToolTipText = "Nueva provincia";
            this.nuevaProvinciaToolStripButton.Click += new System.EventHandler(this.NuevaProvincia);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 71);
            // 
            // nuevaComunaToolStripButton
            // 
            this.nuevaComunaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevaComunaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevaComunaToolStripButton.Image")));
            this.nuevaComunaToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevaComunaToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevaComunaToolStripButton.Name = "nuevaComunaToolStripButton";
            this.nuevaComunaToolStripButton.Size = new System.Drawing.Size(68, 68);
            this.nuevaComunaToolStripButton.Text = "Guardar";
            this.nuevaComunaToolStripButton.Click += new System.EventHandler(this.NuevaComuna);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // nuevaSucursalToolStripButton
            // 
            this.nuevaSucursalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevaSucursalToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevaSucursalToolStripButton.Image")));
            this.nuevaSucursalToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevaSucursalToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevaSucursalToolStripButton.Name = "nuevaSucursalToolStripButton";
            this.nuevaSucursalToolStripButton.Size = new System.Drawing.Size(68, 68);
            this.nuevaSucursalToolStripButton.Text = "Nueva sucursal";
            this.nuevaSucursalToolStripButton.Click += new System.EventHandler(this.NuevaSucursal);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 71);
            // 
            // nuevaVentaToolStripButton
            // 
            this.nuevaVentaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevaVentaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevaVentaToolStripButton.Image")));
            this.nuevaVentaToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevaVentaToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevaVentaToolStripButton.Name = "nuevaVentaToolStripButton";
            this.nuevaVentaToolStripButton.Size = new System.Drawing.Size(68, 68);
            this.nuevaVentaToolStripButton.Text = "Nueva venta";
            this.nuevaVentaToolStripButton.Click += new System.EventHandler(this.NuevaVenta);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 68);
            this.helpToolStripButton.Text = "Ayuda";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem nuevoStock;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosMenu;
        private System.Windows.Forms.ToolStripMenuItem nuevaRegion;
        private System.Windows.Forms.ToolStripMenuItem nuevaProvincia;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaSucursal;
        private System.Windows.Forms.ToolStripMenuItem nuevaBodega;
        private System.Windows.Forms.ToolStripMenuItem nuevoArticulo;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosMenu;
        private System.Windows.Forms.ToolStripMenuItem nuevaVenta;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripButton nuevaToolStripButtonRegion;
        private System.Windows.Forms.ToolStripButton nuevaProvinciaToolStripButton;
        private System.Windows.Forms.ToolStripButton nuevaComunaToolStripButton;
        private System.Windows.Forms.ToolStripButton nuevaSucursalToolStripButton;
        private System.Windows.Forms.ToolStripButton nuevaVentaToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem nuevoCliente;
        private System.Windows.Forms.ToolStripMenuItem nuevoVendedor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    }
}



