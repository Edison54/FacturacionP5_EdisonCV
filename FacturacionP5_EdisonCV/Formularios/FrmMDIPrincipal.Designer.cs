namespace FacturacionP5_EdisonCV.Formularios
{
    partial class FrmMDIPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuClientesGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUsuariosGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProductosGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuEmpresaGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gestionDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFacturar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cobroFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.notasDeCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.registroDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionPorRangoDeFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionPorUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.listaDeImpuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeCategoriaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acerdaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblUsuarioLogeado = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.TmrEstablecerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.acerdaDeToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuClientesGestion,
            this.MnuUsuariosGestion,
            this.MnuProductosGestion,
            this.toolStripSeparator2,
            this.MnuEmpresaGestion,
            this.toolStripSeparator3,
            this.gestionDeProveedoresToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // MnuClientesGestion
            // 
            this.MnuClientesGestion.Name = "MnuClientesGestion";
            this.MnuClientesGestion.Size = new System.Drawing.Size(198, 22);
            this.MnuClientesGestion.Text = "Gestion de clientes";
            // 
            // MnuUsuariosGestion
            // 
            this.MnuUsuariosGestion.Name = "MnuUsuariosGestion";
            this.MnuUsuariosGestion.Size = new System.Drawing.Size(198, 22);
            this.MnuUsuariosGestion.Text = "Gestion de Usuarios";
            this.MnuUsuariosGestion.Click += new System.EventHandler(this.gestioDeUsuariosToolStripMenuItem_Click);
            // 
            // MnuProductosGestion
            // 
            this.MnuProductosGestion.Name = "MnuProductosGestion";
            this.MnuProductosGestion.Size = new System.Drawing.Size(198, 22);
            this.MnuProductosGestion.Text = "Gestion de productos";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // MnuEmpresaGestion
            // 
            this.MnuEmpresaGestion.Name = "MnuEmpresaGestion";
            this.MnuEmpresaGestion.Size = new System.Drawing.Size(198, 22);
            this.MnuEmpresaGestion.Text = "Gestion de empresa";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(195, 6);
            // 
            // gestionDeProveedoresToolStripMenuItem
            // 
            this.gestionDeProveedoresToolStripMenuItem.Enabled = false;
            this.gestionDeProveedoresToolStripMenuItem.Name = "gestionDeProveedoresToolStripMenuItem";
            this.gestionDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.gestionDeProveedoresToolStripMenuItem.Text = "Gestion de proveedores";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFacturar,
            this.toolStripSeparator1,
            this.cobroFacturasToolStripMenuItem,
            this.toolStripSeparator5,
            this.notasDeCreditoToolStripMenuItem,
            this.toolStripSeparator6,
            this.registroDeCompraToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // MnuFacturar
            // 
            this.MnuFacturar.Name = "MnuFacturar";
            this.MnuFacturar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.MnuFacturar.Size = new System.Drawing.Size(180, 22);
            this.MnuFacturar.Text = "Facturacion";
            this.MnuFacturar.Click += new System.EventHandler(this.MnuFacturar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // cobroFacturasToolStripMenuItem
            // 
            this.cobroFacturasToolStripMenuItem.Enabled = false;
            this.cobroFacturasToolStripMenuItem.Name = "cobroFacturasToolStripMenuItem";
            this.cobroFacturasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cobroFacturasToolStripMenuItem.Text = "Cobro Facturas";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // notasDeCreditoToolStripMenuItem
            // 
            this.notasDeCreditoToolStripMenuItem.Enabled = false;
            this.notasDeCreditoToolStripMenuItem.Name = "notasDeCreditoToolStripMenuItem";
            this.notasDeCreditoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notasDeCreditoToolStripMenuItem.Text = "Notas de credito";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // registroDeCompraToolStripMenuItem
            // 
            this.registroDeCompraToolStripMenuItem.Enabled = false;
            this.registroDeCompraToolStripMenuItem.Name = "registroDeCompraToolStripMenuItem";
            this.registroDeCompraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroDeCompraToolStripMenuItem.Text = "Registro de compra";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionPorRangoDeFechasToolStripMenuItem,
            this.facturacionClienteToolStripMenuItem,
            this.facturacionPorUsuarioToolStripMenuItem,
            this.toolStripSeparator4,
            this.listadoDeClientesToolStripMenuItem,
            this.listadoUsuariosToolStripMenuItem,
            this.toolStripSeparator7,
            this.listaDeImpuestosToolStripMenuItem,
            this.listaDeCategoriaDeProductosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // facturacionPorRangoDeFechasToolStripMenuItem
            // 
            this.facturacionPorRangoDeFechasToolStripMenuItem.Name = "facturacionPorRangoDeFechasToolStripMenuItem";
            this.facturacionPorRangoDeFechasToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.facturacionPorRangoDeFechasToolStripMenuItem.Text = "Facturacion por rango de fechas";
            // 
            // facturacionClienteToolStripMenuItem
            // 
            this.facturacionClienteToolStripMenuItem.Name = "facturacionClienteToolStripMenuItem";
            this.facturacionClienteToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.facturacionClienteToolStripMenuItem.Text = "Facturacion por  cliente";
            // 
            // facturacionPorUsuarioToolStripMenuItem
            // 
            this.facturacionPorUsuarioToolStripMenuItem.Name = "facturacionPorUsuarioToolStripMenuItem";
            this.facturacionPorUsuarioToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.facturacionPorUsuarioToolStripMenuItem.Text = "Facturacion por usuario";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(241, 6);
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            this.listadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.listadoDeClientesToolStripMenuItem.Text = "Listado de clientes";
            // 
            // listadoUsuariosToolStripMenuItem
            // 
            this.listadoUsuariosToolStripMenuItem.Name = "listadoUsuariosToolStripMenuItem";
            this.listadoUsuariosToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.listadoUsuariosToolStripMenuItem.Text = "Listado de usuarios";
            this.listadoUsuariosToolStripMenuItem.Click += new System.EventHandler(this.listadoUsuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(241, 6);
            // 
            // listaDeImpuestosToolStripMenuItem
            // 
            this.listaDeImpuestosToolStripMenuItem.Name = "listaDeImpuestosToolStripMenuItem";
            this.listaDeImpuestosToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.listaDeImpuestosToolStripMenuItem.Text = "Lista de impuestos";
            // 
            // listaDeCategoriaDeProductosToolStripMenuItem
            // 
            this.listaDeCategoriaDeProductosToolStripMenuItem.Name = "listaDeCategoriaDeProductosToolStripMenuItem";
            this.listaDeCategoriaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.listaDeCategoriaDeProductosToolStripMenuItem.Text = "Lista de categoria de productos";
            // 
            // acerdaDeToolStripMenuItem
            // 
            this.acerdaDeToolStripMenuItem.Name = "acerdaDeToolStripMenuItem";
            this.acerdaDeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.acerdaDeToolStripMenuItem.Text = "Acerda de";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LblUsuarioLogeado,
            this.LblFechaHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // LblUsuarioLogeado
            // 
            this.LblUsuarioLogeado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuarioLogeado.Name = "LblUsuarioLogeado";
            this.LblUsuarioLogeado.Size = new System.Drawing.Size(14, 17);
            this.LblUsuarioLogeado.Text = "u";
            // 
            // LblFechaHora
            // 
            this.LblFechaHora.Name = "LblFechaHora";
            this.LblFechaHora.Size = new System.Drawing.Size(721, 17);
            this.LblFechaHora.Spring = true;
            this.LblFechaHora.Text = "Hora";
            this.LblFechaHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblFechaHora.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // TmrEstablecerFechaHora
            // 
            this.TmrEstablecerFechaHora.Interval = 1000;
            this.TmrEstablecerFechaHora.Tick += new System.EventHandler(this.TmrEstablecerFechaHora_Tick);
            // 
            // FrmMDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "FrmMDIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE FACTURACION P5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMDIPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmMDIPrincipal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuClientesGestion;
        private System.Windows.Forms.ToolStripMenuItem MnuUsuariosGestion;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acerdaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuProductosGestion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MnuEmpresaGestion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuFacturar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cobroFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionPorRangoDeFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionPorUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem notasDeCreditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem registroDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem listaDeImpuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeCategoriaDeProductosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LblUsuarioLogeado;
        private System.Windows.Forms.ToolStripStatusLabel LblFechaHora;
        private System.Windows.Forms.Timer TmrEstablecerFechaHora;
    }
}