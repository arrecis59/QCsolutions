namespace CapaInterfazMantenimientoUsuarios
{
    partial class InterfazCrearUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazCrearUsuarios));
            this.Txt_contra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_Inferior = new System.Windows.Forms.Panel();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_asignacionPerfiles = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CodigoUsuario = new System.Windows.Forms.TextBox();
            this.pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_contra
            // 
            this.Txt_contra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_contra.Location = new System.Drawing.Point(216, 312);
            this.Txt_contra.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Txt_contra.Name = "Txt_contra";
            this.Txt_contra.PasswordChar = '*';
            this.Txt_contra.Size = new System.Drawing.Size(673, 27);
            this.Txt_contra.TabIndex = 27;
            this.Txt_contra.Tag = "3";
            this.Txt_contra.TextChanged += new System.EventHandler(this.Txt_contra_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(108, 312);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Contraseña:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.Location = new System.Drawing.Point(216, 274);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(673, 27);
            this.Txt_Nombre.TabIndex = 25;
            this.Txt_Nombre.Tag = "2";
            this.Txt_Nombre.TextChanged += new System.EventHandler(this.Txt_Nombre_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(43, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nombre del Usuario:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_Inferior
            // 
            this.pnl_Inferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnl_Inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Inferior.Location = new System.Drawing.Point(0, 620);
            this.pnl_Inferior.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnl_Inferior.Name = "pnl_Inferior";
            this.pnl_Inferior.Size = new System.Drawing.Size(950, 30);
            this.pnl_Inferior.TabIndex = 96;
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnl_Titulo.Controls.Add(this.btn_minimizar);
            this.pnl_Titulo.Controls.Add(this.btn_cerrar);
            this.pnl_Titulo.Controls.Add(this.Lbl_asignacionPerfiles);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(950, 30);
            this.pnl_Titulo.TabIndex = 95;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_minimizar.Location = new System.Drawing.Point(875, 0);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(30, 30);
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
            this.btn_cerrar.Location = new System.Drawing.Point(905, 0);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(45, 30);
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
            this.Lbl_asignacionPerfiles.Location = new System.Drawing.Point(8, 5);
            this.Lbl_asignacionPerfiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_asignacionPerfiles.Name = "Lbl_asignacionPerfiles";
            this.Lbl_asignacionPerfiles.Size = new System.Drawing.Size(136, 19);
            this.Lbl_asignacionPerfiles.TabIndex = 48;
            this.Lbl_asignacionPerfiles.Text = "Ingreso de usuarios";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navegador1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(0, 30);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(950, 50);
            this.navegador1.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(148, 350);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 98;
            this.label2.Text = "Status:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Status
            // 
            this.txt_Status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Status.Location = new System.Drawing.Point(215, 350);
            this.txt_Status.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(674, 27);
            this.txt_Status.TabIndex = 99;
            this.txt_Status.Tag = "4";
            this.txt_Status.Text = "1";
            this.txt_Status.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(58, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 100;
            this.label3.Text = "Codigo de usuario:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_CodigoUsuario
            // 
            this.txt_CodigoUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoUsuario.Location = new System.Drawing.Point(216, 236);
            this.txt_CodigoUsuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_CodigoUsuario.Name = "txt_CodigoUsuario";
            this.txt_CodigoUsuario.Size = new System.Drawing.Size(673, 27);
            this.txt_CodigoUsuario.TabIndex = 101;
            this.txt_CodigoUsuario.Tag = "1";
            // 
            // InterfazCrearUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.txt_CodigoUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.pnl_Inferior);
            this.Controls.Add(this.pnl_Titulo);
            this.Controls.Add(this.Txt_contra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InterfazCrearUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Usuario";
            this.Load += new System.EventHandler(this.InterfazCrearUsuarios_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.InterfazCrearUsuarios_HelpRequested);
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_contra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_Inferior;
        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label Lbl_asignacionPerfiles;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CodigoUsuario;
    }
}