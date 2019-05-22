namespace procesoGestion
{
    partial class SeguimientoGestion
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_asignacionPerfiles = new System.Windows.Forms.Label();
            this.dgv_gestion = new System.Windows.Forms.DataGridView();
            this.rbtn_pendiente = new System.Windows.Forms.RadioButton();
            this.rbtn_solucionados = new System.Windows.Forms.RadioButton();
            this.grp_tipo_busqueda = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gestion)).BeginInit();
            this.grp_tipo_busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 30);
            this.panel2.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.Lbl_asignacionPerfiles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 30);
            this.panel1.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 19);
            this.label7.TabIndex = 49;
            this.label7.Text = "-----";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.Lbl_asignacionPerfiles.Location = new System.Drawing.Point(65, 6);
            this.Lbl_asignacionPerfiles.Name = "Lbl_asignacionPerfiles";
            this.Lbl_asignacionPerfiles.Size = new System.Drawing.Size(143, 19);
            this.Lbl_asignacionPerfiles.TabIndex = 48;
            this.Lbl_asignacionPerfiles.Text = "Seguimiento Gestion";
            // 
            // dgv_gestion
            // 
            this.dgv_gestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gestion.Location = new System.Drawing.Point(13, 112);
            this.dgv_gestion.Name = "dgv_gestion";
            this.dgv_gestion.Size = new System.Drawing.Size(925, 492);
            this.dgv_gestion.TabIndex = 74;
            this.dgv_gestion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gestion_CellDoubleClick);
            // 
            // rbtn_pendiente
            // 
            this.rbtn_pendiente.AutoSize = true;
            this.rbtn_pendiente.Checked = true;
            this.rbtn_pendiente.Location = new System.Drawing.Point(6, 26);
            this.rbtn_pendiente.Name = "rbtn_pendiente";
            this.rbtn_pendiente.Size = new System.Drawing.Size(99, 23);
            this.rbtn_pendiente.TabIndex = 75;
            this.rbtn_pendiente.TabStop = true;
            this.rbtn_pendiente.Text = "Pendientes";
            this.rbtn_pendiente.UseVisualStyleBackColor = true;
            this.rbtn_pendiente.CheckedChanged += new System.EventHandler(this.rbtn_pendiente_CheckedChanged);
            // 
            // rbtn_solucionados
            // 
            this.rbtn_solucionados.AutoSize = true;
            this.rbtn_solucionados.Location = new System.Drawing.Point(123, 26);
            this.rbtn_solucionados.Name = "rbtn_solucionados";
            this.rbtn_solucionados.Size = new System.Drawing.Size(112, 23);
            this.rbtn_solucionados.TabIndex = 76;
            this.rbtn_solucionados.Text = "Solucionados";
            this.rbtn_solucionados.UseVisualStyleBackColor = true;
            this.rbtn_solucionados.CheckedChanged += new System.EventHandler(this.rbtn_solucionados_CheckedChanged);
            // 
            // grp_tipo_busqueda
            // 
            this.grp_tipo_busqueda.Controls.Add(this.rbtn_pendiente);
            this.grp_tipo_busqueda.Controls.Add(this.rbtn_solucionados);
            this.grp_tipo_busqueda.Location = new System.Drawing.Point(13, 37);
            this.grp_tipo_busqueda.Name = "grp_tipo_busqueda";
            this.grp_tipo_busqueda.Size = new System.Drawing.Size(246, 69);
            this.grp_tipo_busqueda.TabIndex = 77;
            this.grp_tipo_busqueda.TabStop = false;
            this.grp_tipo_busqueda.Text = "TIPO DE BUSQUEDAS";
            // 
            // SeguimientoGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.grp_tipo_busqueda);
            this.Controls.Add(this.dgv_gestion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SeguimientoGestion";
            this.Text = "SeguimientoGestion";
            this.Load += new System.EventHandler(this.SeguimientoGestion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gestion)).EndInit();
            this.grp_tipo_busqueda.ResumeLayout(false);
            this.grp_tipo_busqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label Lbl_asignacionPerfiles;
        private System.Windows.Forms.DataGridView dgv_gestion;
        private System.Windows.Forms.RadioButton rbtn_pendiente;
        private System.Windows.Forms.RadioButton rbtn_solucionados;
        private System.Windows.Forms.GroupBox grp_tipo_busqueda;
    }
}