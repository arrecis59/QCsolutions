namespace CapaInterfazMantenimientoAplicaciones
{
    partial class InterfazIngrearAplicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazIngrearAplicaciones));
            this.Txt_nombre_Modulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbo_nombre_modulo = new System.Windows.Forms.ComboBox();
            this.Txt_NombreApp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_CodigoApp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_Inferior = new System.Windows.Forms.Panel();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_asignacionPerfiles = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_nombre_Modulo
            // 
            this.Txt_nombre_Modulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre_Modulo.Location = new System.Drawing.Point(248, 312);
            this.Txt_nombre_Modulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_nombre_Modulo.Name = "Txt_nombre_Modulo";
            this.Txt_nombre_Modulo.ReadOnly = true;
            this.Txt_nombre_Modulo.Size = new System.Drawing.Size(108, 27);
            this.Txt_nombre_Modulo.TabIndex = 83;
            this.Txt_nombre_Modulo.Tag = "3";
            this.Txt_nombre_Modulo.TextChanged += new System.EventHandler(this.Txt_nombre_Modulo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(71, 312);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 82;
            this.label1.Text = "Nombre del Modulo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Cbo_nombre_modulo
            // 
            this.Cbo_nombre_modulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_nombre_modulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_nombre_modulo.FormattingEnabled = true;
            this.Cbo_nombre_modulo.Location = new System.Drawing.Point(365, 312);
            this.Cbo_nombre_modulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_nombre_modulo.Name = "Cbo_nombre_modulo";
            this.Cbo_nombre_modulo.Size = new System.Drawing.Size(529, 27);
            this.Cbo_nombre_modulo.TabIndex = 81;
            this.Cbo_nombre_modulo.SelectedIndexChanged += new System.EventHandler(this.Cbo_nombre_modulo_SelectedIndexChanged);
            // 
            // Txt_NombreApp
            // 
            this.Txt_NombreApp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreApp.Location = new System.Drawing.Point(248, 277);
            this.Txt_NombreApp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_NombreApp.Name = "Txt_NombreApp";
            this.Txt_NombreApp.Size = new System.Drawing.Size(647, 27);
            this.Txt_NombreApp.TabIndex = 78;
            this.Txt_NombreApp.Tag = "2";
            this.Txt_NombreApp.TextChanged += new System.EventHandler(this.Txt_NombreApp_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(57, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 23);
            this.label6.TabIndex = 77;
            this.label6.Text = "Nombre de Aplicacion:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_CodigoApp
            // 
            this.Txt_CodigoApp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodigoApp.Location = new System.Drawing.Point(248, 242);
            this.Txt_CodigoApp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_CodigoApp.Name = "Txt_CodigoApp";
            this.Txt_CodigoApp.Size = new System.Drawing.Size(647, 27);
            this.Txt_CodigoApp.TabIndex = 76;
            this.Txt_CodigoApp.Tag = "1";
            this.Txt_CodigoApp.TextChanged += new System.EventHandler(this.Txt_CodigoApp_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(67, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 23);
            this.label5.TabIndex = 75;
            this.label5.Text = "Codigo de Aplicacion:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_Inferior
            // 
            this.pnl_Inferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnl_Inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Inferior.Location = new System.Drawing.Point(0, 620);
            this.pnl_Inferior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Inferior.Name = "pnl_Inferior";
            this.pnl_Inferior.Size = new System.Drawing.Size(950, 30);
            this.pnl_Inferior.TabIndex = 85;
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
            this.pnl_Titulo.TabIndex = 84;
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
            this.Lbl_asignacionPerfiles.Size = new System.Drawing.Size(162, 19);
            this.Lbl_asignacionPerfiles.TabIndex = 48;
            this.Lbl_asignacionPerfiles.Text = "Ingreso de aplicaciones";
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
            this.navegador1.TabIndex = 86;
            // 
            // txt_Status
            // 
            this.txt_Status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Status.Location = new System.Drawing.Point(248, 347);
            this.txt_Status.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(647, 27);
            this.txt_Status.TabIndex = 88;
            this.txt_Status.Tag = "4";
            this.txt_Status.Text = "1";
            this.txt_Status.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(177, 347);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 87;
            this.label2.Text = "Status:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InterfazIngrearAplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.pnl_Inferior);
            this.Controls.Add(this.pnl_Titulo);
            this.Controls.Add(this.Txt_nombre_Modulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbo_nombre_modulo);
            this.Controls.Add(this.Txt_NombreApp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_CodigoApp);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InterfazIngrearAplicaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz_Ingrear_Aplicaciones";
            this.Load += new System.EventHandler(this.InterfazIngrearAplicaciones_Load);
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_nombre_Modulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbo_nombre_modulo;
        private System.Windows.Forms.TextBox Txt_NombreApp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_CodigoApp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_Inferior;
        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label Lbl_asignacionPerfiles;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label label2;
    }
}