namespace CreaClase
{
    partial class Form1
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
            this.cb_dbs = new System.Windows.Forms.ComboBox();
            this.lbl_bds = new System.Windows.Forms.Label();
            this.btn_getbds = new System.Windows.Forms.Button();
            this.cb_tablas = new System.Windows.Forms.ComboBox();
            this.lbl_tablas = new System.Windows.Forms.Label();
            this.btn_generaClase = new System.Windows.Forms.Button();
            this.btn_webApi = new System.Windows.Forms.Button();
            this.btn_generaHTML = new System.Windows.Forms.Button();
            this.tb_col = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_dbs
            // 
            this.cb_dbs.FormattingEnabled = true;
            this.cb_dbs.Location = new System.Drawing.Point(28, 26);
            this.cb_dbs.Name = "cb_dbs";
            this.cb_dbs.Size = new System.Drawing.Size(121, 21);
            this.cb_dbs.TabIndex = 0;
            this.cb_dbs.SelectedIndexChanged += new System.EventHandler(this.cb_dbs_SelectedIndexChanged);
            // 
            // lbl_bds
            // 
            this.lbl_bds.AutoSize = true;
            this.lbl_bds.Location = new System.Drawing.Point(28, 13);
            this.lbl_bds.Name = "lbl_bds";
            this.lbl_bds.Size = new System.Drawing.Size(83, 13);
            this.lbl_bds.TabIndex = 1;
            this.lbl_bds.Text = "Bases de datos:";
            // 
            // btn_getbds
            // 
            this.btn_getbds.Location = new System.Drawing.Point(155, 26);
            this.btn_getbds.Name = "btn_getbds";
            this.btn_getbds.Size = new System.Drawing.Size(102, 23);
            this.btn_getbds.TabIndex = 2;
            this.btn_getbds.Text = "Obtener BD´s";
            this.btn_getbds.UseVisualStyleBackColor = true;
            this.btn_getbds.Click += new System.EventHandler(this.btn_getbds_Click);
            // 
            // cb_tablas
            // 
            this.cb_tablas.FormattingEnabled = true;
            this.cb_tablas.Location = new System.Drawing.Point(31, 68);
            this.cb_tablas.Name = "cb_tablas";
            this.cb_tablas.Size = new System.Drawing.Size(121, 21);
            this.cb_tablas.TabIndex = 3;
            // 
            // lbl_tablas
            // 
            this.lbl_tablas.AutoSize = true;
            this.lbl_tablas.Location = new System.Drawing.Point(27, 54);
            this.lbl_tablas.Name = "lbl_tablas";
            this.lbl_tablas.Size = new System.Drawing.Size(42, 13);
            this.lbl_tablas.TabIndex = 4;
            this.lbl_tablas.Text = "Tablas:";
            // 
            // btn_generaClase
            // 
            this.btn_generaClase.Location = new System.Drawing.Point(158, 68);
            this.btn_generaClase.Name = "btn_generaClase";
            this.btn_generaClase.Size = new System.Drawing.Size(75, 23);
            this.btn_generaClase.TabIndex = 5;
            this.btn_generaClase.Text = "Generar";
            this.btn_generaClase.UseVisualStyleBackColor = true;
            this.btn_generaClase.Click += new System.EventHandler(this.btn_generaClase_Click);
            // 
            // btn_webApi
            // 
            this.btn_webApi.Location = new System.Drawing.Point(239, 68);
            this.btn_webApi.Name = "btn_webApi";
            this.btn_webApi.Size = new System.Drawing.Size(153, 23);
            this.btn_webApi.TabIndex = 6;
            this.btn_webApi.Text = "Generar Archivos WebApi";
            this.btn_webApi.UseVisualStyleBackColor = true;
            this.btn_webApi.Click += new System.EventHandler(this.btn_webApi_Click);
            // 
            // btn_generaHTML
            // 
            this.btn_generaHTML.Location = new System.Drawing.Point(239, 110);
            this.btn_generaHTML.Name = "btn_generaHTML";
            this.btn_generaHTML.Size = new System.Drawing.Size(153, 23);
            this.btn_generaHTML.TabIndex = 7;
            this.btn_generaHTML.Text = "Crea forma HTML";
            this.btn_generaHTML.UseVisualStyleBackColor = true;
            this.btn_generaHTML.Click += new System.EventHandler(this.btn_generaHTML_Click);
            // 
            // tb_col
            // 
            this.tb_col.Location = new System.Drawing.Point(192, 112);
            this.tb_col.Name = "tb_col";
            this.tb_col.Size = new System.Drawing.Size(41, 20);
            this.tb_col.TabIndex = 8;
            this.tb_col.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Número de columnas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_col);
            this.Controls.Add(this.btn_generaHTML);
            this.Controls.Add(this.btn_webApi);
            this.Controls.Add(this.btn_generaClase);
            this.Controls.Add(this.lbl_tablas);
            this.Controls.Add(this.cb_tablas);
            this.Controls.Add(this.btn_getbds);
            this.Controls.Add(this.lbl_bds);
            this.Controls.Add(this.cb_dbs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_dbs;
        private System.Windows.Forms.Label lbl_bds;
        private System.Windows.Forms.Button btn_getbds;
        private System.Windows.Forms.ComboBox cb_tablas;
        private System.Windows.Forms.Label lbl_tablas;
        private System.Windows.Forms.Button btn_generaClase;
        private System.Windows.Forms.Button btn_webApi;
        private System.Windows.Forms.Button btn_generaHTML;
        private System.Windows.Forms.TextBox tb_col;
        private System.Windows.Forms.Label label1;
    }
}

