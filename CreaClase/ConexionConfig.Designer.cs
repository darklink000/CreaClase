namespace CreaClase
{
    partial class ConexionConfig
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_host = new System.Windows.Forms.TextBox();
            this.lbl_host = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.tb_contraseña = new System.Windows.Forms.TextBox();
            this.gb_generales = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.gb_motores = new System.Windows.Forms.GroupBox();
            this.rb_mysql = new System.Windows.Forms.RadioButton();
            this.rb_sqlServer = new System.Windows.Forms.RadioButton();
            this.gb_generales.SuspendLayout();
            this.gb_motores.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_host
            // 
            this.tb_host.Location = new System.Drawing.Point(6, 45);
            this.tb_host.Name = "tb_host";
            this.tb_host.Size = new System.Drawing.Size(258, 20);
            this.tb_host.TabIndex = 0;
            // 
            // lbl_host
            // 
            this.lbl_host.AutoSize = true;
            this.lbl_host.Location = new System.Drawing.Point(6, 26);
            this.lbl_host.Name = "lbl_host";
            this.lbl_host.Size = new System.Drawing.Size(32, 13);
            this.lbl_host.TabIndex = 1;
            this.lbl_host.Text = "Host:";
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(9, 95);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(255, 20);
            this.tb_usuario.TabIndex = 2;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(9, 76);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(64, 13);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Usuario BD:";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Location = new System.Drawing.Point(9, 127);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(82, 13);
            this.lbl_contraseña.TabIndex = 5;
            this.lbl_contraseña.Text = "Contraseña BD:";
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.Location = new System.Drawing.Point(9, 146);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.PasswordChar = '*';
            this.tb_contraseña.Size = new System.Drawing.Size(255, 20);
            this.tb_contraseña.TabIndex = 4;
            // 
            // gb_generales
            // 
            this.gb_generales.Controls.Add(this.gb_motores);
            this.gb_generales.Controls.Add(this.btn_guardar);
            this.gb_generales.Controls.Add(this.tb_host);
            this.gb_generales.Controls.Add(this.lbl_contraseña);
            this.gb_generales.Controls.Add(this.lbl_host);
            this.gb_generales.Controls.Add(this.tb_contraseña);
            this.gb_generales.Controls.Add(this.tb_usuario);
            this.gb_generales.Controls.Add(this.lbl_nombre);
            this.gb_generales.Location = new System.Drawing.Point(3, 3);
            this.gb_generales.Name = "gb_generales";
            this.gb_generales.Size = new System.Drawing.Size(320, 298);
            this.gb_generales.TabIndex = 6;
            this.gb_generales.TabStop = false;
            this.gb_generales.Text = "Datos de conexión:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(245, 269);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // gb_motores
            // 
            this.gb_motores.Controls.Add(this.rb_sqlServer);
            this.gb_motores.Controls.Add(this.rb_mysql);
            this.gb_motores.Location = new System.Drawing.Point(12, 172);
            this.gb_motores.Name = "gb_motores";
            this.gb_motores.Size = new System.Drawing.Size(178, 120);
            this.gb_motores.TabIndex = 7;
            this.gb_motores.TabStop = false;
            this.gb_motores.Text = "BD soportados:";
            // 
            // rb_mysql
            // 
            this.rb_mysql.AutoSize = true;
            this.rb_mysql.Location = new System.Drawing.Point(12, 19);
            this.rb_mysql.Name = "rb_mysql";
            this.rb_mysql.Size = new System.Drawing.Size(60, 17);
            this.rb_mysql.TabIndex = 0;
            this.rb_mysql.TabStop = true;
            this.rb_mysql.Text = "MySQL";
            this.rb_mysql.UseVisualStyleBackColor = true;
            // 
            // rb_sqlServer
            // 
            this.rb_sqlServer.AutoSize = true;
            this.rb_sqlServer.Location = new System.Drawing.Point(12, 42);
            this.rb_sqlServer.Name = "rb_sqlServer";
            this.rb_sqlServer.Size = new System.Drawing.Size(80, 17);
            this.rb_sqlServer.TabIndex = 1;
            this.rb_sqlServer.TabStop = true;
            this.rb_sqlServer.Text = "SQL Server";
            this.rb_sqlServer.UseVisualStyleBackColor = true;
            // 
            // ConexionConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_generales);
            this.Name = "ConexionConfig";
            this.Size = new System.Drawing.Size(326, 309);
            this.Load += new System.EventHandler(this.ConexionConfig_Load);
            this.gb_generales.ResumeLayout(false);
            this.gb_generales.PerformLayout();
            this.gb_motores.ResumeLayout(false);
            this.gb_motores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_host;
        private System.Windows.Forms.Label lbl_host;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.TextBox tb_contraseña;
        private System.Windows.Forms.GroupBox gb_generales;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox gb_motores;
        private System.Windows.Forms.RadioButton rb_sqlServer;
        private System.Windows.Forms.RadioButton rb_mysql;
    }
}
