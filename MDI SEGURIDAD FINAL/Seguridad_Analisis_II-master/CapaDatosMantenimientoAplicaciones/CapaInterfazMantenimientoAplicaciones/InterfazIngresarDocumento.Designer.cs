namespace CapaInterfazMantenimientoAplicaciones
{
    partial class InterfazIngresarDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazIngresarDocumento));
            this.Txt_codigoAppi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbo_nombre_appi = new System.Windows.Forms.ComboBox();
            this.Txt_NombreDoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_CodigoDoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Ruta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnl_Inferior = new System.Windows.Forms.Panel();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_asignacionPerfiles = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_codigoAppi
            // 
            this.Txt_codigoAppi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigoAppi.Location = new System.Drawing.Point(261, 369);
            this.Txt_codigoAppi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_codigoAppi.Name = "Txt_codigoAppi";
            this.Txt_codigoAppi.ReadOnly = true;
            this.Txt_codigoAppi.Size = new System.Drawing.Size(108, 27);
            this.Txt_codigoAppi.TabIndex = 94;
            this.Txt_codigoAppi.Tag = "4";
            this.Txt_codigoAppi.TextChanged += new System.EventHandler(this.Txt_codigoAppi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 369);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 93;
            this.label1.Text = "Nombre de la aplicacion:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Cbo_nombre_appi
            // 
            this.Cbo_nombre_appi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_nombre_appi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_nombre_appi.FormattingEnabled = true;
            this.Cbo_nombre_appi.Location = new System.Drawing.Point(378, 369);
            this.Cbo_nombre_appi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_nombre_appi.Name = "Cbo_nombre_appi";
            this.Cbo_nombre_appi.Size = new System.Drawing.Size(448, 27);
            this.Cbo_nombre_appi.TabIndex = 92;
            this.Cbo_nombre_appi.SelectedIndexChanged += new System.EventHandler(this.Cbo_nombre_modulo_SelectedIndexChanged);
            // 
            // Txt_NombreDoc
            // 
            this.Txt_NombreDoc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreDoc.Location = new System.Drawing.Point(261, 274);
            this.Txt_NombreDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_NombreDoc.Name = "Txt_NombreDoc";
            this.Txt_NombreDoc.Size = new System.Drawing.Size(567, 27);
            this.Txt_NombreDoc.TabIndex = 89;
            this.Txt_NombreDoc.Tag = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(58, 274);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 23);
            this.label6.TabIndex = 88;
            this.label6.Text = "Nombre de Documento:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_CodigoDoc
            // 
            this.Txt_CodigoDoc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodigoDoc.Location = new System.Drawing.Point(261, 227);
            this.Txt_CodigoDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_CodigoDoc.Name = "Txt_CodigoDoc";
            this.Txt_CodigoDoc.Size = new System.Drawing.Size(567, 27);
            this.Txt_CodigoDoc.TabIndex = 87;
            this.Txt_CodigoDoc.Tag = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(68, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 23);
            this.label5.TabIndex = 86;
            this.label5.Text = "Codigo de Documento:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_Ruta
            // 
            this.Txt_Ruta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Ruta.Location = new System.Drawing.Point(262, 324);
            this.Txt_Ruta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Ruta.Name = "Txt_Ruta";
            this.Txt_Ruta.Size = new System.Drawing.Size(520, 27);
            this.Txt_Ruta.TabIndex = 96;
            this.Txt_Ruta.Tag = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(84, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 95;
            this.label3.Text = "Ruta del documento:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(792, 320);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 27);
            this.button1.TabIndex = 97;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnl_Inferior
            // 
            this.pnl_Inferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnl_Inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Inferior.Location = new System.Drawing.Point(0, 620);
            this.pnl_Inferior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Inferior.Name = "pnl_Inferior";
            this.pnl_Inferior.Size = new System.Drawing.Size(950, 30);
            this.pnl_Inferior.TabIndex = 99;
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnl_Titulo.Controls.Add(this.btn_minimizar);
            this.pnl_Titulo.Controls.Add(this.btn_cerrar);
            this.pnl_Titulo.Controls.Add(this.Lbl_asignacionPerfiles);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(950, 30);
            this.pnl_Titulo.TabIndex = 98;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_minimizar.Location = new System.Drawing.Point(870, 0);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(40, 30);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.Text = "_";
            this.btn_minimizar.UseVisualStyleBackColor = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btn_cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_cerrar.Location = new System.Drawing.Point(910, 0);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(40, 30);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "x";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Lbl_asignacionPerfiles
            // 
            this.Lbl_asignacionPerfiles.AutoSize = true;
            this.Lbl_asignacionPerfiles.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_asignacionPerfiles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_asignacionPerfiles.Location = new System.Drawing.Point(13, 9);
            this.Lbl_asignacionPerfiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_asignacionPerfiles.Name = "Lbl_asignacionPerfiles";
            this.Lbl_asignacionPerfiles.Size = new System.Drawing.Size(215, 19);
            this.Lbl_asignacionPerfiles.TabIndex = 48;
            this.Lbl_asignacionPerfiles.Text = "Ingreso de documento asociado";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(259, 418);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(567, 27);
            this.textBox1.TabIndex = 102;
            this.textBox1.Tag = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(187, 418);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 101;
            this.label2.Text = "Status:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(0, 30);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(950, 55);
            this.navegador1.TabIndex = 103;
            // 
            // InterfazIngresarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl_Inferior);
            this.Controls.Add(this.pnl_Titulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_Ruta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_codigoAppi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbo_nombre_appi);
            this.Controls.Add(this.Txt_NombreDoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_CodigoDoc);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InterfazIngresarDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfazIngresarDocumento";
            this.Load += new System.EventHandler(this.InterfazIngresarDocumento_Load);
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_codigoAppi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbo_nombre_appi;
        private System.Windows.Forms.TextBox Txt_NombreDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_CodigoDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Ruta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnl_Inferior;
        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label Lbl_asignacionPerfiles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private CapaDiseno.Navegador navegador1;
    }
}