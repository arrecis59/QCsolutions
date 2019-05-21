namespace OperacionesExternas.OperacionExterna
{
    partial class AddBenExterno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBenExterno));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_asignacionPerfiles = new System.Windows.Forms.Label();
            this.txt_CuentaDestino = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_NDoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TipoDoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Apellido2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Apellido1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcb_Id = new System.Windows.Forms.PictureBox();
            this.chb_ID = new System.Windows.Forms.CheckBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TipoCuentaDestino = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_Cliente = new System.Windows.Forms.ComboBox();
            this.txt_BancoExterno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_BancoExterno = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Id)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 30);
            this.panel2.TabIndex = 128;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.Lbl_asignacionPerfiles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 30);
            this.panel1.TabIndex = 127;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btn_cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_cerrar.Location = new System.Drawing.Point(720, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(30, 30);
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
            this.Lbl_asignacionPerfiles.Location = new System.Drawing.Point(10, 6);
            this.Lbl_asignacionPerfiles.Name = "Lbl_asignacionPerfiles";
            this.Lbl_asignacionPerfiles.Size = new System.Drawing.Size(211, 19);
            this.Lbl_asignacionPerfiles.TabIndex = 48;
            this.Lbl_asignacionPerfiles.Text = "Ingreso de Beneficiario Externo";
            // 
            // txt_CuentaDestino
            // 
            this.txt_CuentaDestino.Location = new System.Drawing.Point(75, 122);
            this.txt_CuentaDestino.Name = "txt_CuentaDestino";
            this.txt_CuentaDestino.Size = new System.Drawing.Size(271, 27);
            this.txt_CuentaDestino.TabIndex = 186;
            this.txt_CuentaDestino.TextChanged += new System.EventHandler(this.txt_CuentaDestino_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 19);
            this.label11.TabIndex = 185;
            this.label11.Text = "Cuenta Destino";
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(352, 330);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(297, 27);
            this.txt_Correo.TabIndex = 184;
            this.txt_Correo.TextChanged += new System.EventHandler(this.txt_CuentaDestino_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 19);
            this.label10.TabIndex = 183;
            this.label10.Text = "Correo";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Clear.Location = new System.Drawing.Point(401, 422);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(121, 37);
            this.btn_Clear.TabIndex = 182;
            this.btn_Clear.Text = "Limpiar";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.Green;
            this.btn_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_aceptar.Location = new System.Drawing.Point(528, 422);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(121, 37);
            this.btn_aceptar.TabIndex = 181;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_NDoc
            // 
            this.txt_NDoc.Location = new System.Drawing.Point(352, 278);
            this.txt_NDoc.Name = "txt_NDoc";
            this.txt_NDoc.Size = new System.Drawing.Size(297, 27);
            this.txt_NDoc.TabIndex = 174;
            this.txt_NDoc.TextChanged += new System.EventHandler(this.txt_CuentaDestino_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 19);
            this.label6.TabIndex = 173;
            this.label6.Text = "Numero de documento";
            // 
            // txt_TipoDoc
            // 
            this.txt_TipoDoc.Location = new System.Drawing.Point(75, 278);
            this.txt_TipoDoc.Name = "txt_TipoDoc";
            this.txt_TipoDoc.Size = new System.Drawing.Size(271, 27);
            this.txt_TipoDoc.TabIndex = 172;
            this.txt_TipoDoc.TextChanged += new System.EventHandler(this.txt_CuentaDestino_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 171;
            this.label5.Text = "Tipo de Documento";
            // 
            // txt_Apellido2
            // 
            this.txt_Apellido2.Location = new System.Drawing.Point(352, 226);
            this.txt_Apellido2.Name = "txt_Apellido2";
            this.txt_Apellido2.Size = new System.Drawing.Size(297, 27);
            this.txt_Apellido2.TabIndex = 170;
            this.txt_Apellido2.TextChanged += new System.EventHandler(this.txt_CuentaDestino_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 169;
            this.label4.Text = "Apellido 2";
            // 
            // txt_Apellido1
            // 
            this.txt_Apellido1.Location = new System.Drawing.Point(75, 226);
            this.txt_Apellido1.Name = "txt_Apellido1";
            this.txt_Apellido1.Size = new System.Drawing.Size(271, 27);
            this.txt_Apellido1.TabIndex = 168;
            this.txt_Apellido1.TextChanged += new System.EventHandler(this.txt_CuentaDestino_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 167;
            this.label3.Text = "Apellido 1";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(75, 174);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(574, 27);
            this.txt_Nombre.TabIndex = 166;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.txt_CuentaDestino_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 165;
            this.label1.Text = "Nombre Cliente";
            // 
            // pcb_Id
            // 
            this.pcb_Id.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcb_Id.BackgroundImage")));
            this.pcb_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcb_Id.Location = new System.Drawing.Point(42, 70);
            this.pcb_Id.Name = "pcb_Id";
            this.pcb_Id.Size = new System.Drawing.Size(27, 27);
            this.pcb_Id.TabIndex = 164;
            this.pcb_Id.TabStop = false;
            this.pcb_Id.Visible = false;
            // 
            // chb_ID
            // 
            this.chb_ID.AutoSize = true;
            this.chb_ID.Location = new System.Drawing.Point(655, 72);
            this.chb_ID.Name = "chb_ID";
            this.chb_ID.Size = new System.Drawing.Size(58, 23);
            this.chb_ID.TabIndex = 163;
            this.chb_ID.Text = "Auto";
            this.chb_ID.UseVisualStyleBackColor = true;
            this.chb_ID.CheckedChanged += new System.EventHandler(this.chb_ID_CheckedChanged);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(75, 70);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(574, 27);
            this.txt_ID.TabIndex = 162;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 161;
            this.label2.Text = "ID Beneficiario Externo";
            // 
            // txt_TipoCuentaDestino
            // 
            this.txt_TipoCuentaDestino.Location = new System.Drawing.Point(352, 122);
            this.txt_TipoCuentaDestino.Name = "txt_TipoCuentaDestino";
            this.txt_TipoCuentaDestino.Size = new System.Drawing.Size(297, 27);
            this.txt_TipoCuentaDestino.TabIndex = 188;
            this.txt_TipoCuentaDestino.TextChanged += new System.EventHandler(this.txt_CuentaDestino_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(348, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 19);
            this.label12.TabIndex = 187;
            this.label12.Text = "Tipo de Cuenta Destino";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(75, 330);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(271, 27);
            this.txt_Telefono.TabIndex = 190;
            this.txt_Telefono.TextChanged += new System.EventHandler(this.txt_CuentaDestino_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 189;
            this.label7.Text = "Telefono";
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Location = new System.Drawing.Point(75, 382);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.ReadOnly = true;
            this.txt_Cliente.Size = new System.Drawing.Size(70, 27);
            this.txt_Cliente.TabIndex = 193;
            this.txt_Cliente.TextChanged += new System.EventHandler(this.txt_CuentaDestino_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 192;
            this.label8.Text = "Cliente";
            // 
            // cbo_Cliente
            // 
            this.cbo_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Cliente.FormattingEnabled = true;
            this.cbo_Cliente.Location = new System.Drawing.Point(151, 382);
            this.cbo_Cliente.Name = "cbo_Cliente";
            this.cbo_Cliente.Size = new System.Drawing.Size(195, 27);
            this.cbo_Cliente.TabIndex = 191;
            this.cbo_Cliente.SelectedIndexChanged += new System.EventHandler(this.cbo_Cliente_SelectedIndexChanged);
            // 
            // txt_BancoExterno
            // 
            this.txt_BancoExterno.Location = new System.Drawing.Point(352, 382);
            this.txt_BancoExterno.Name = "txt_BancoExterno";
            this.txt_BancoExterno.ReadOnly = true;
            this.txt_BancoExterno.Size = new System.Drawing.Size(70, 27);
            this.txt_BancoExterno.TabIndex = 196;
            this.txt_BancoExterno.TextChanged += new System.EventHandler(this.txt_CuentaDestino_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 195;
            this.label9.Text = "Banco Externo";
            // 
            // cbo_BancoExterno
            // 
            this.cbo_BancoExterno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_BancoExterno.FormattingEnabled = true;
            this.cbo_BancoExterno.Location = new System.Drawing.Point(428, 382);
            this.cbo_BancoExterno.Name = "cbo_BancoExterno";
            this.cbo_BancoExterno.Size = new System.Drawing.Size(221, 27);
            this.cbo_BancoExterno.TabIndex = 194;
            this.cbo_BancoExterno.SelectedIndexChanged += new System.EventHandler(this.cbo_BancoExterno_SelectedIndexChanged);
            // 
            // AddBenExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.txt_BancoExterno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbo_BancoExterno);
            this.Controls.Add(this.txt_Cliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbo_Cliente);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_TipoCuentaDestino);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_CuentaDestino);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_NDoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TipoDoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Apellido2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Apellido1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_Id);
            this.Controls.Add(this.chb_ID);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddBenExterno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBenExterno";
            this.Load += new System.EventHandler(this.AddBenExterno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label Lbl_asignacionPerfiles;
        private System.Windows.Forms.TextBox txt_CuentaDestino;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txt_NDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TipoDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Apellido2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Apellido1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcb_Id;
        private System.Windows.Forms.CheckBox chb_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TipoCuentaDestino;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_Cliente;
        private System.Windows.Forms.TextBox txt_BancoExterno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_BancoExterno;
    }
}