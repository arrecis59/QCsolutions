namespace CapaInterfazAsignacionDePerfiles
{
    partial class InterfazAsignacionDePerfiles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazAsignacionDePerfiles));
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.Cbo_usuarios = new System.Windows.Forms.ComboBox();
            this.Lbl_asignacionPerfiles = new System.Windows.Forms.Label();
            this.Dgv_asignacion = new System.Windows.Forms.DataGridView();
            this.Dgv_asignacion2 = new System.Windows.Forms.DataGridView();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_quitar = new System.Windows.Forms.Button();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.pnl_Inferior = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion2)).BeginInit();
            this.pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_usuario.Location = new System.Drawing.Point(81, 83);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(75, 23);
            this.Lbl_usuario.TabIndex = 52;
            this.Lbl_usuario.Text = "Usuario:";
            this.Lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Cbo_usuarios
            // 
            this.Cbo_usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_usuarios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_usuarios.FormattingEnabled = true;
            this.Cbo_usuarios.Location = new System.Drawing.Point(246, 83);
            this.Cbo_usuarios.Name = "Cbo_usuarios";
            this.Cbo_usuarios.Size = new System.Drawing.Size(623, 27);
            this.Cbo_usuarios.TabIndex = 50;
            this.Cbo_usuarios.SelectedIndexChanged += new System.EventHandler(this.Cbo_usuarios_SelectedIndexChanged);
            // 
            // Lbl_asignacionPerfiles
            // 
            this.Lbl_asignacionPerfiles.AutoSize = true;
            this.Lbl_asignacionPerfiles.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_asignacionPerfiles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_asignacionPerfiles.Location = new System.Drawing.Point(10, 6);
            this.Lbl_asignacionPerfiles.Name = "Lbl_asignacionPerfiles";
            this.Lbl_asignacionPerfiles.Size = new System.Drawing.Size(158, 19);
            this.Lbl_asignacionPerfiles.TabIndex = 48;
            this.Lbl_asignacionPerfiles.Text = "Asignacion  De Perfiles";
            // 
            // Dgv_asignacion
            // 
            this.Dgv_asignacion.AllowUserToAddRows = false;
            this.Dgv_asignacion.AllowUserToDeleteRows = false;
            this.Dgv_asignacion.AllowUserToOrderColumns = true;
            this.Dgv_asignacion.AllowUserToResizeColumns = false;
            this.Dgv_asignacion.AllowUserToResizeRows = false;
            this.Dgv_asignacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_asignacion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_asignacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_asignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_asignacion.EnableHeadersVisualStyles = false;
            this.Dgv_asignacion.Location = new System.Drawing.Point(162, 138);
            this.Dgv_asignacion.Name = "Dgv_asignacion";
            this.Dgv_asignacion.RowHeadersVisible = false;
            this.Dgv_asignacion.Size = new System.Drawing.Size(322, 401);
            this.Dgv_asignacion.TabIndex = 53;
            this.Dgv_asignacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_asignacion_CellContentClick);
            this.Dgv_asignacion.SelectionChanged += new System.EventHandler(this.Dgv_asignacion_SelectionChanged);
            // 
            // Dgv_asignacion2
            // 
            this.Dgv_asignacion2.AllowUserToAddRows = false;
            this.Dgv_asignacion2.AllowUserToDeleteRows = false;
            this.Dgv_asignacion2.AllowUserToOrderColumns = true;
            this.Dgv_asignacion2.AllowUserToResizeColumns = false;
            this.Dgv_asignacion2.AllowUserToResizeRows = false;
            this.Dgv_asignacion2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_asignacion2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_asignacion2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_asignacion2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_asignacion2.EnableHeadersVisualStyles = false;
            this.Dgv_asignacion2.Location = new System.Drawing.Point(556, 138);
            this.Dgv_asignacion2.Name = "Dgv_asignacion2";
            this.Dgv_asignacion2.RowHeadersVisible = false;
            this.Dgv_asignacion2.Size = new System.Drawing.Size(313, 401);
            this.Dgv_asignacion2.TabIndex = 54;
            this.Dgv_asignacion2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_asignacion2_CellContentClick);
            this.Dgv_asignacion2.SelectionChanged += new System.EventHandler(this.Dgv_asignacion2_SelectionChanged);
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Btn_agregar.FlatAppearance.BorderSize = 0;
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_agregar.Location = new System.Drawing.Point(490, 258);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(60, 60);
            this.Btn_agregar.TabIndex = 55;
            this.Btn_agregar.Tag = "";
            this.Btn_agregar.Text = ">";
            this.Btn_agregar.UseVisualStyleBackColor = false;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Btn_quitar
            // 
            this.Btn_quitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Btn_quitar.FlatAppearance.BorderSize = 0;
            this.Btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_quitar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_quitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_quitar.Location = new System.Drawing.Point(490, 332);
            this.Btn_quitar.Name = "Btn_quitar";
            this.Btn_quitar.Size = new System.Drawing.Size(60, 60);
            this.Btn_quitar.TabIndex = 56;
            this.Btn_quitar.Text = "<";
            this.Btn_quitar.UseVisualStyleBackColor = false;
            this.Btn_quitar.Click += new System.EventHandler(this.Btn_quitar_Click);
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_usuario.Location = new System.Drawing.Point(162, 83);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.ReadOnly = true;
            this.Txt_usuario.Size = new System.Drawing.Size(80, 27);
            this.Txt_usuario.TabIndex = 57;
            this.Txt_usuario.TextChanged += new System.EventHandler(this.Txt_usuario_TextChanged);
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnl_Titulo.Controls.Add(this.btn_minimizar);
            this.pnl_Titulo.Controls.Add(this.btn_cerrar);
            this.pnl_Titulo.Controls.Add(this.Lbl_asignacionPerfiles);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(950, 30);
            this.pnl_Titulo.TabIndex = 58;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_minimizar.Location = new System.Drawing.Point(880, 0);
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
            this.btn_cerrar.Location = new System.Drawing.Point(910, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(40, 30);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "x";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // pnl_Inferior
            // 
            this.pnl_Inferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnl_Inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Inferior.Location = new System.Drawing.Point(0, 620);
            this.pnl_Inferior.Name = "pnl_Inferior";
            this.pnl_Inferior.Size = new System.Drawing.Size(950, 30);
            this.pnl_Inferior.TabIndex = 59;
            // 
            // InterfazAsignacionDePerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.pnl_Inferior);
            this.Controls.Add(this.pnl_Titulo);
            this.Controls.Add(this.Txt_usuario);
            this.Controls.Add(this.Btn_quitar);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.Dgv_asignacion2);
            this.Controls.Add(this.Dgv_asignacion);
            this.Controls.Add(this.Lbl_usuario);
            this.Controls.Add(this.Cbo_usuarios);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InterfazAsignacionDePerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz_Asignacion_De_Perfiles";
            this.Load += new System.EventHandler(this.InterfazAsignacionDePerfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion2)).EndInit();
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.ComboBox Cbo_usuarios;
        private System.Windows.Forms.Label Lbl_asignacionPerfiles;
        private System.Windows.Forms.DataGridView Dgv_asignacion;
        private System.Windows.Forms.DataGridView Dgv_asignacion2;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_quitar;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Panel pnl_Inferior;
    }
}