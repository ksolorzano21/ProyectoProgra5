namespace Progra5Compras.Formularios
{
    partial class Frm_Usuario_Gestion
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
            this.Dgv_Listado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.Cbox_VerEliminados = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_ID_USUARIO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Cedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Contrasenna = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_VerContrasenna = new System.Windows.Forms.Button();
            this.Cbox_Eliminado = new System.Windows.Forms.CheckBox();
            this.C_ID_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Contrasenna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Eliminado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.C_ID_USUARIO_TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_TipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Listado
            // 
            this.Dgv_Listado.AllowUserToAddRows = false;
            this.Dgv_Listado.AllowUserToDeleteRows = false;
            this.Dgv_Listado.AllowUserToOrderColumns = true;
            this.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_ID_USUARIO,
            this.C_Nombre,
            this.C_Cedula,
            this.C_NombreUsuario,
            this.C_Contrasenna,
            this.C_Email,
            this.C_Eliminado,
            this.C_ID_USUARIO_TIPO,
            this.C_TipoUsuario});
            this.Dgv_Listado.Location = new System.Drawing.Point(22, 40);
            this.Dgv_Listado.Name = "Dgv_Listado";
            this.Dgv_Listado.ReadOnly = true;
            this.Dgv_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Listado.Size = new System.Drawing.Size(766, 142);
            this.Dgv_Listado.TabIndex = 0;
            this.Dgv_Listado.VirtualMode = true;
            this.Dgv_Listado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Listado_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cbox_Eliminado);
            this.groupBox1.Controls.Add(this.Btn_VerContrasenna);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Txt_Email);
            this.groupBox1.Controls.Add(this.Txt_Contrasenna);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Txt_NombreUsuario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_Cedula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_Nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_ID_USUARIO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Usuario";
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.DarkGreen;
            this.Btn_Agregar.ForeColor = System.Drawing.Color.White;
            this.Btn_Agregar.Location = new System.Drawing.Point(48, 319);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(93, 41);
            this.Btn_Agregar.TabIndex = 2;
            this.Btn_Agregar.Text = "AGREGAR";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.Btn_Modificar.Location = new System.Drawing.Point(194, 319);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(96, 41);
            this.Btn_Modificar.TabIndex = 3;
            this.Btn_Modificar.Text = "MODIFICAR";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.DarkRed;
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Location = new System.Drawing.Point(352, 319);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(97, 41);
            this.Btn_Eliminar.TabIndex = 4;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.Color.RoyalBlue;
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.Btn_Limpiar.Location = new System.Drawing.Point(503, 319);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(107, 41);
            this.Btn_Limpiar.TabIndex = 5;
            this.Btn_Limpiar.Text = "LIMPIAR";
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.Black;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cerrar.Location = new System.Drawing.Point(671, 319);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(98, 41);
            this.Btn_Cerrar.TabIndex = 6;
            this.Btn_Cerrar.Text = "CERRAR";
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "BUSCAR";
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Buscar.Location = new System.Drawing.Point(107, 8);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(183, 26);
            this.Txt_Buscar.TabIndex = 8;
            // 
            // Cbox_VerEliminados
            // 
            this.Cbox_VerEliminados.AutoSize = true;
            this.Cbox_VerEliminados.Location = new System.Drawing.Point(630, 12);
            this.Cbox_VerEliminados.Name = "Cbox_VerEliminados";
            this.Cbox_VerEliminados.Size = new System.Drawing.Size(139, 17);
            this.Cbox_VerEliminados.TabIndex = 9;
            this.Cbox_VerEliminados.Text = "Ver Usuarios Eliminados";
            this.Cbox_VerEliminados.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo";
            // 
            // Txt_ID_USUARIO
            // 
            this.Txt_ID_USUARIO.Location = new System.Drawing.Point(85, 17);
            this.Txt_ID_USUARIO.Name = "Txt_ID_USUARIO";
            this.Txt_ID_USUARIO.ReadOnly = true;
            this.Txt_ID_USUARIO.Size = new System.Drawing.Size(100, 20);
            this.Txt_ID_USUARIO.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(85, 43);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(207, 20);
            this.Txt_Nombre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cedula";
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.Location = new System.Drawing.Point(85, 69);
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.Size = new System.Drawing.Size(207, 20);
            this.Txt_Cedula.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre Usuario";
            // 
            // Txt_NombreUsuario
            // 
            this.Txt_NombreUsuario.Location = new System.Drawing.Point(461, 20);
            this.Txt_NombreUsuario.Name = "Txt_NombreUsuario";
            this.Txt_NombreUsuario.Size = new System.Drawing.Size(161, 20);
            this.Txt_NombreUsuario.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contraseña";
            // 
            // Txt_Contrasenna
            // 
            this.Txt_Contrasenna.Location = new System.Drawing.Point(461, 46);
            this.Txt_Contrasenna.Name = "Txt_Contrasenna";
            this.Txt_Contrasenna.Size = new System.Drawing.Size(161, 20);
            this.Txt_Contrasenna.TabIndex = 9;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(461, 72);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(161, 20);
            this.Txt_Email.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email";
            // 
            // Btn_VerContrasenna
            // 
            this.Btn_VerContrasenna.Location = new System.Drawing.Point(638, 46);
            this.Btn_VerContrasenna.Name = "Btn_VerContrasenna";
            this.Btn_VerContrasenna.Size = new System.Drawing.Size(49, 23);
            this.Btn_VerContrasenna.TabIndex = 12;
            this.Btn_VerContrasenna.Text = "Ver";
            this.Btn_VerContrasenna.UseVisualStyleBackColor = true;
            // 
            // Cbox_Eliminado
            // 
            this.Cbox_Eliminado.AutoSize = true;
            this.Cbox_Eliminado.Enabled = false;
            this.Cbox_Eliminado.Location = new System.Drawing.Point(461, 104);
            this.Cbox_Eliminado.Name = "Cbox_Eliminado";
            this.Cbox_Eliminado.Size = new System.Drawing.Size(71, 17);
            this.Cbox_Eliminado.TabIndex = 13;
            this.Cbox_Eliminado.Text = "Eliminado";
            this.Cbox_Eliminado.UseVisualStyleBackColor = true;
            // 
            // C_ID_USUARIO
            // 
            this.C_ID_USUARIO.DataPropertyName = "ID_USUARIO";
            this.C_ID_USUARIO.HeaderText = "CODIGO";
            this.C_ID_USUARIO.Name = "C_ID_USUARIO";
            this.C_ID_USUARIO.ReadOnly = true;
            // 
            // C_Nombre
            // 
            this.C_Nombre.DataPropertyName = "Nombre";
            this.C_Nombre.HeaderText = "NOMBRE";
            this.C_Nombre.Name = "C_Nombre";
            this.C_Nombre.ReadOnly = true;
            // 
            // C_Cedula
            // 
            this.C_Cedula.DataPropertyName = "Cedula";
            this.C_Cedula.HeaderText = "CEDULA";
            this.C_Cedula.Name = "C_Cedula";
            this.C_Cedula.ReadOnly = true;
            // 
            // C_NombreUsuario
            // 
            this.C_NombreUsuario.DataPropertyName = "NombreUsuario";
            this.C_NombreUsuario.HeaderText = "USUARIO";
            this.C_NombreUsuario.Name = "C_NombreUsuario";
            this.C_NombreUsuario.ReadOnly = true;
            // 
            // C_Contrasenna
            // 
            this.C_Contrasenna.DataPropertyName = "Contrasenna";
            this.C_Contrasenna.HeaderText = "PASSWORD";
            this.C_Contrasenna.Name = "C_Contrasenna";
            this.C_Contrasenna.ReadOnly = true;
            // 
            // C_Email
            // 
            this.C_Email.DataPropertyName = "Email";
            this.C_Email.HeaderText = "EMAIL";
            this.C_Email.Name = "C_Email";
            this.C_Email.ReadOnly = true;
            // 
            // C_Eliminado
            // 
            this.C_Eliminado.DataPropertyName = "Eliminado";
            this.C_Eliminado.HeaderText = "ELIMINADO";
            this.C_Eliminado.Name = "C_Eliminado";
            this.C_Eliminado.ReadOnly = true;
            // 
            // C_ID_USUARIO_TIPO
            // 
            this.C_ID_USUARIO_TIPO.DataPropertyName = "ID_USUARIO_TIPO";
            this.C_ID_USUARIO_TIPO.HeaderText = "IDTIPO";
            this.C_ID_USUARIO_TIPO.Name = "C_ID_USUARIO_TIPO";
            this.C_ID_USUARIO_TIPO.ReadOnly = true;
            // 
            // C_TipoUsuario
            // 
            this.C_TipoUsuario.DataPropertyName = "TipoUsuario";
            this.C_TipoUsuario.HeaderText = "TIPO USUARIO";
            this.C_TipoUsuario.Name = "C_TipoUsuario";
            this.C_TipoUsuario.ReadOnly = true;
            // 
            // Frm_Usuario_Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.Cbox_VerEliminados);
            this.Controls.Add(this.Txt_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dgv_Listado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Usuario_Gestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTION DE USUARIOS";
            this.Load += new System.EventHandler(this.Frm_Usuario_Gestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Listado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Buscar;
        private System.Windows.Forms.CheckBox Cbox_VerEliminados;
        private System.Windows.Forms.CheckBox Cbox_Eliminado;
        private System.Windows.Forms.Button Btn_VerContrasenna;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Contrasenna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_NombreUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Cedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_ID_USUARIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ID_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Contrasenna;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn C_Eliminado;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ID_USUARIO_TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_TipoUsuario;
    }
}