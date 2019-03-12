namespace CapaInterfazMantenimientoAplicaciones
{
    partial class InterfazMostrarAplicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazMostrarAplicaciones));
            this.Dgv_aplicaciones = new System.Windows.Forms.DataGridView();
            this.pnl_Inferior = new System.Windows.Forms.Panel();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_asignacionPerfiles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_aplicaciones)).BeginInit();
            this.pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_aplicaciones
            // 
            this.Dgv_aplicaciones.AllowUserToDeleteRows = false;
            this.Dgv_aplicaciones.AllowUserToOrderColumns = true;
            this.Dgv_aplicaciones.AllowUserToResizeColumns = false;
            this.Dgv_aplicaciones.AllowUserToResizeRows = false;
            this.Dgv_aplicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_aplicaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_aplicaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_aplicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_aplicaciones.EnableHeadersVisualStyles = false;
            this.Dgv_aplicaciones.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dgv_aplicaciones.Location = new System.Drawing.Point(31, 48);
            this.Dgv_aplicaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dgv_aplicaciones.Name = "Dgv_aplicaciones";
            this.Dgv_aplicaciones.RowHeadersVisible = false;
            this.Dgv_aplicaciones.Size = new System.Drawing.Size(893, 547);
            this.Dgv_aplicaciones.TabIndex = 24;
            this.Dgv_aplicaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_aplicaciones_CellClick);
            this.Dgv_aplicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_aplicaciones_CellContentClick);
            // 
            // pnl_Inferior
            // 
            this.pnl_Inferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnl_Inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Inferior.Location = new System.Drawing.Point(0, 620);
            this.pnl_Inferior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Inferior.Name = "pnl_Inferior";
            this.pnl_Inferior.Size = new System.Drawing.Size(950, 30);
            this.pnl_Inferior.TabIndex = 61;
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
            this.pnl_Titulo.TabIndex = 60;
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
            this.Lbl_asignacionPerfiles.Size = new System.Drawing.Size(171, 19);
            this.Lbl_asignacionPerfiles.TabIndex = 48;
            this.Lbl_asignacionPerfiles.Text = "Consulta de aplicaciones";
            // 
            // InterfazMostrarAplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.pnl_Inferior);
            this.Controls.Add(this.pnl_Titulo);
            this.Controls.Add(this.Dgv_aplicaciones);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InterfazMostrarAplicaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfazMostrarAplicaciones";
            this.Load += new System.EventHandler(this.InterfazMostrarAplicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_aplicaciones)).EndInit();
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_aplicaciones;
        private System.Windows.Forms.Panel pnl_Inferior;
        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label Lbl_asignacionPerfiles;
    }
}