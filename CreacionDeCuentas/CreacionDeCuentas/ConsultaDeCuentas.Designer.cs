namespace CreacionDeCuentas
{
    partial class ConsultaDeCuentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaDeCuentas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_asignacionPerfiles = new System.Windows.Forms.Label();
            this.dtg_Cuentas = new System.Windows.Forms.DataGridView();
            this.cbo_TipoBusqueda = new System.Windows.Forms.ComboBox();
            this.txt_Busqueda = new System.Windows.Forms.TextBox();
            this.btn_Refrescar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Cuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 30);
            this.panel2.TabIndex = 83;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.Lbl_asignacionPerfiles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 30);
            this.panel1.TabIndex = 82;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_minimizar.Location = new System.Drawing.Point(890, 0);
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
            this.btn_cerrar.Location = new System.Drawing.Point(920, 0);
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
            this.Lbl_asignacionPerfiles.Size = new System.Drawing.Size(141, 19);
            this.Lbl_asignacionPerfiles.TabIndex = 48;
            this.Lbl_asignacionPerfiles.Text = "Creacion de cuentas";
            // 
            // dtg_Cuentas
            // 
            this.dtg_Cuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Cuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Cuentas.EnableHeadersVisualStyles = false;
            this.dtg_Cuentas.Location = new System.Drawing.Point(14, 109);
            this.dtg_Cuentas.Name = "dtg_Cuentas";
            this.dtg_Cuentas.ReadOnly = true;
            this.dtg_Cuentas.RowHeadersVisible = false;
            this.dtg_Cuentas.Size = new System.Drawing.Size(924, 471);
            this.dtg_Cuentas.TabIndex = 117;
            this.dtg_Cuentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Cuentas_CellClick);
            this.dtg_Cuentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Cuentas_CellDoubleClick);
            // 
            // cbo_TipoBusqueda
            // 
            this.cbo_TipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TipoBusqueda.FormattingEnabled = true;
            this.cbo_TipoBusqueda.Items.AddRange(new object[] {
            "Numero de Cuenta",
            "Codigo de Cuenta",
            "Fecha de Creacion",
            "Agencia",
            "Organizacion"});
            this.cbo_TipoBusqueda.Location = new System.Drawing.Point(14, 67);
            this.cbo_TipoBusqueda.Name = "cbo_TipoBusqueda";
            this.cbo_TipoBusqueda.Size = new System.Drawing.Size(163, 27);
            this.cbo_TipoBusqueda.TabIndex = 118;
            // 
            // txt_Busqueda
            // 
            this.txt_Busqueda.Location = new System.Drawing.Point(183, 67);
            this.txt_Busqueda.Name = "txt_Busqueda";
            this.txt_Busqueda.Size = new System.Drawing.Size(722, 27);
            this.txt_Busqueda.TabIndex = 119;
            this.txt_Busqueda.TextChanged += new System.EventHandler(this.txt_Busqueda_TextChanged);
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Refrescar.BackgroundImage")));
            this.btn_Refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Refrescar.FlatAppearance.BorderSize = 0;
            this.btn_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refrescar.Location = new System.Drawing.Point(911, 66);
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(27, 27);
            this.btn_Refrescar.TabIndex = 120;
            this.btn_Refrescar.UseVisualStyleBackColor = true;
            this.btn_Refrescar.Click += new System.EventHandler(this.btn_Refrescar_Click);
            // 
            // ConsultaDeCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.btn_Refrescar);
            this.Controls.Add(this.txt_Busqueda);
            this.Controls.Add(this.cbo_TipoBusqueda);
            this.Controls.Add(this.dtg_Cuentas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConsultaDeCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaDeCuentas";
            this.Load += new System.EventHandler(this.ConsultaDeCuentas_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ConsultaDeCuentas_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Cuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label Lbl_asignacionPerfiles;
        private System.Windows.Forms.DataGridView dtg_Cuentas;
        private System.Windows.Forms.ComboBox cbo_TipoBusqueda;
        private System.Windows.Forms.TextBox txt_Busqueda;
        private System.Windows.Forms.Button btn_Refrescar;
    }
}