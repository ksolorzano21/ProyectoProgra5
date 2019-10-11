namespace Progra5Compras.Formularios
{
    partial class Frm_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Mnu_Mantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Procesos = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_AcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Empresa = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Productos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_RegistroCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Mantenimientos,
            this.Mnu_Procesos,
            this.Mnu_Reportes,
            this.Mnu_AcercaDe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Mnu_Mantenimientos
            // 
            this.Mnu_Mantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Usuarios,
            this.toolStripSeparator1,
            this.Mnu_Empresa,
            this.toolStripSeparator2,
            this.Mnu_Proveedores,
            this.Mnu_Productos});
            this.Mnu_Mantenimientos.Name = "Mnu_Mantenimientos";
            this.Mnu_Mantenimientos.Size = new System.Drawing.Size(120, 20);
            this.Mnu_Mantenimientos.Text = "MANTENIMIENTOS";
            // 
            // Mnu_Procesos
            // 
            this.Mnu_Procesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_RegistroCompra});
            this.Mnu_Procesos.Name = "Mnu_Procesos";
            this.Mnu_Procesos.Size = new System.Drawing.Size(77, 20);
            this.Mnu_Procesos.Text = "PROCESOS";
            // 
            // Mnu_Reportes
            // 
            this.Mnu_Reportes.Name = "Mnu_Reportes";
            this.Mnu_Reportes.Size = new System.Drawing.Size(72, 20);
            this.Mnu_Reportes.Text = "REPORTES";
            // 
            // Mnu_AcercaDe
            // 
            this.Mnu_AcercaDe.Name = "Mnu_AcercaDe";
            this.Mnu_AcercaDe.Size = new System.Drawing.Size(80, 20);
            this.Mnu_AcercaDe.Text = "Acerca de...";
            // 
            // Mnu_Usuarios
            // 
            this.Mnu_Usuarios.Name = "Mnu_Usuarios";
            this.Mnu_Usuarios.Size = new System.Drawing.Size(180, 22);
            this.Mnu_Usuarios.Text = "USUARIOS";
            this.Mnu_Usuarios.Click += new System.EventHandler(this.Mnu_Usuarios_Click);
            // 
            // Mnu_Empresa
            // 
            this.Mnu_Empresa.Name = "Mnu_Empresa";
            this.Mnu_Empresa.Size = new System.Drawing.Size(180, 22);
            this.Mnu_Empresa.Text = "EMPRESA";
            // 
            // Mnu_Proveedores
            // 
            this.Mnu_Proveedores.Name = "Mnu_Proveedores";
            this.Mnu_Proveedores.Size = new System.Drawing.Size(180, 22);
            this.Mnu_Proveedores.Text = "PROVEEDORES";
            // 
            // Mnu_Productos
            // 
            this.Mnu_Productos.Name = "Mnu_Productos";
            this.Mnu_Productos.Size = new System.Drawing.Size(180, 22);
            this.Mnu_Productos.Text = "PRODUCTOS";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // Mnu_RegistroCompra
            // 
            this.Mnu_RegistroCompra.Name = "Mnu_RegistroCompra";
            this.Mnu_RegistroCompra.Size = new System.Drawing.Size(196, 22);
            this.Mnu_RegistroCompra.Text = "REGISTRO DE COMPRA";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DECONTROL DE COMPRA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Principal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Mantenimientos;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Usuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Empresa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Proveedores;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Productos;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Procesos;
        private System.Windows.Forms.ToolStripMenuItem Mnu_RegistroCompra;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Reportes;
        private System.Windows.Forms.ToolStripMenuItem Mnu_AcercaDe;
    }
}