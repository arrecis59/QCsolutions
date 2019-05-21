namespace CreacionDeCuentas
{
    partial class AddOrg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrg));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_asignacionPerfiles = new System.Windows.Forms.Label();
            this.pcb_IdCuenta = new System.Windows.Forms.PictureBox();
            this.chb_IDOrg = new System.Windows.Forms.CheckBox();
            this.txt_idOrg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombreOrg = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_IdCuenta)).BeginInit();
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
            this.Lbl_asignacionPerfiles.Size = new System.Drawing.Size(181, 19);
            this.Lbl_asignacionPerfiles.TabIndex = 48;
            this.Lbl_asignacionPerfiles.Text = "Ingreso de Organizaciones";
            // 
            // pcb_IdCuenta
            // 
            this.pcb_IdCuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcb_IdCuenta.BackgroundImage")));
            this.pcb_IdCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcb_IdCuenta.Location = new System.Drawing.Point(47, 147);
            this.pcb_IdCuenta.Name = "pcb_IdCuenta";
            this.pcb_IdCuenta.Size = new System.Drawing.Size(27, 27);
            this.pcb_IdCuenta.TabIndex = 132;
            this.pcb_IdCuenta.TabStop = false;
            this.pcb_IdCuenta.Visible = false;
            // 
            // chb_IDOrg
            // 
            this.chb_IDOrg.AutoSize = true;
            this.chb_IDOrg.Location = new System.Drawing.Point(660, 149);
            this.chb_IDOrg.Name = "chb_IDOrg";
            this.chb_IDOrg.Size = new System.Drawing.Size(58, 23);
            this.chb_IDOrg.TabIndex = 131;
            this.chb_IDOrg.Text = "Auto";
            this.chb_IDOrg.UseVisualStyleBackColor = true;
            this.chb_IDOrg.CheckedChanged += new System.EventHandler(this.chb_IDOrg_CheckedChanged);
            // 
            // txt_idOrg
            // 
            this.txt_idOrg.Location = new System.Drawing.Point(80, 147);
            this.txt_idOrg.Name = "txt_idOrg";
            this.txt_idOrg.Size = new System.Drawing.Size(574, 27);
            this.txt_idOrg.TabIndex = 130;
            this.txt_idOrg.TextChanged += new System.EventHandler(this.txt_idOrg_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 129;
            this.label2.Text = "ID Organizacion";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.Green;
            this.btn_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_aceptar.Location = new System.Drawing.Point(533, 359);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(121, 37);
            this.btn_aceptar.TabIndex = 135;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Clear.Location = new System.Drawing.Point(406, 359);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(121, 37);
            this.btn_Clear.TabIndex = 136;
            this.btn_Clear.Text = "Limpiar";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 133;
            this.label1.Text = "Nombre de la Organizacion";
            // 
            // txt_nombreOrg
            // 
            this.txt_nombreOrg.Location = new System.Drawing.Point(80, 251);
            this.txt_nombreOrg.Name = "txt_nombreOrg";
            this.txt_nombreOrg.Size = new System.Drawing.Size(574, 27);
            this.txt_nombreOrg.TabIndex = 134;
            this.txt_nombreOrg.TextChanged += new System.EventHandler(this.txt_nombreOrg_TextChanged);
            // 
            // AddOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_nombreOrg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_IdCuenta);
            this.Controls.Add(this.chb_IDOrg);
            this.Controls.Add(this.txt_idOrg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddOrg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrg";
            this.Load += new System.EventHandler(this.AddOrg_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_IdCuenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label Lbl_asignacionPerfiles;
        private System.Windows.Forms.PictureBox pcb_IdCuenta;
        private System.Windows.Forms.CheckBox chb_IDOrg;
        private System.Windows.Forms.TextBox txt_idOrg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombreOrg;
    }
}