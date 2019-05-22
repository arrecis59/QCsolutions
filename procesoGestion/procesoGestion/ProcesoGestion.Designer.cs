namespace procesoGestion
{
    partial class frm_proceso_gestion
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_asignacionPerfiles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idGestion = new System.Windows.Forms.TextBox();
            this.grp_cliente = new System.Windows.Forms.GroupBox();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_genero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fecNac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nomCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txt_dpi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grp_gestion = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.cmb_prioridad = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_motivo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.grp_cliente.SuspendLayout();
            this.grp_gestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 30);
            this.panel2.TabIndex = 71;
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
            this.panel1.TabIndex = 70;
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
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click_1);
            // 
            // Lbl_asignacionPerfiles
            // 
            this.Lbl_asignacionPerfiles.AutoSize = true;
            this.Lbl_asignacionPerfiles.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_asignacionPerfiles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_asignacionPerfiles.Location = new System.Drawing.Point(65, 6);
            this.Lbl_asignacionPerfiles.Name = "Lbl_asignacionPerfiles";
            this.Lbl_asignacionPerfiles.Size = new System.Drawing.Size(114, 19);
            this.Lbl_asignacionPerfiles.TabIndex = 48;
            this.Lbl_asignacionPerfiles.Text = "Proceso Gestion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 72;
            this.label1.Text = "No. Gestión:";
            // 
            // txt_idGestion
            // 
            this.txt_idGestion.Location = new System.Drawing.Point(775, 43);
            this.txt_idGestion.Name = "txt_idGestion";
            this.txt_idGestion.Size = new System.Drawing.Size(98, 27);
            this.txt_idGestion.TabIndex = 73;
            // 
            // grp_cliente
            // 
            this.grp_cliente.Controls.Add(this.txt_nit);
            this.grp_cliente.Controls.Add(this.label11);
            this.grp_cliente.Controls.Add(this.txt_celular);
            this.grp_cliente.Controls.Add(this.label9);
            this.grp_cliente.Controls.Add(this.txt_telefono);
            this.grp_cliente.Controls.Add(this.label10);
            this.grp_cliente.Controls.Add(this.txt_correo);
            this.grp_cliente.Controls.Add(this.label8);
            this.grp_cliente.Controls.Add(this.txt_genero);
            this.grp_cliente.Controls.Add(this.label6);
            this.grp_cliente.Controls.Add(this.txt_fecNac);
            this.grp_cliente.Controls.Add(this.label5);
            this.grp_cliente.Controls.Add(this.txt_nomCliente);
            this.grp_cliente.Controls.Add(this.label3);
            this.grp_cliente.Controls.Add(this.btnBuscarCliente);
            this.grp_cliente.Controls.Add(this.txt_dpi);
            this.grp_cliente.Controls.Add(this.label2);
            this.grp_cliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grp_cliente.Location = new System.Drawing.Point(12, 76);
            this.grp_cliente.Name = "grp_cliente";
            this.grp_cliente.Size = new System.Drawing.Size(925, 143);
            this.grp_cliente.TabIndex = 76;
            this.grp_cliente.TabStop = false;
            this.grp_cliente.Text = "INFORMACION DE CLIENTE";
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(793, 102);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(120, 27);
            this.txt_nit.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(750, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 19);
            this.label11.TabIndex = 80;
            this.label11.Text = "Nit: ";
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(593, 102);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(150, 27);
            this.txt_celular.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 78;
            this.label9.Text = "Celular: ";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(368, 103);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(150, 27);
            this.txt_telefono.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Telefono: ";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(82, 97);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(200, 27);
            this.txt_correo.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Correo: ";
            // 
            // txt_genero
            // 
            this.txt_genero.Location = new System.Drawing.Point(813, 63);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(100, 27);
            this.txt_genero.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(743, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Genero: ";
            // 
            // txt_fecNac
            // 
            this.txt_fecNac.Location = new System.Drawing.Point(617, 63);
            this.txt_fecNac.Name = "txt_fecNac";
            this.txt_fecNac.Size = new System.Drawing.Size(120, 27);
            this.txt_fecNac.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de Nacmiento: ";
            // 
            // txt_nomCliente
            // 
            this.txt_nomCliente.Location = new System.Drawing.Point(156, 63);
            this.txt_nomCliente.Name = "txt_nomCliente";
            this.txt_nomCliente.Size = new System.Drawing.Size(300, 27);
            this.txt_nomCliente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre Completo: ";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(218, 28);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 30);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txt_dpi
            // 
            this.txt_dpi.Location = new System.Drawing.Point(61, 30);
            this.txt_dpi.Name = "txt_dpi";
            this.txt_dpi.Size = new System.Drawing.Size(150, 27);
            this.txt_dpi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "DPI: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 77;
            this.label4.Text = "Fecha: ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(879, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 23);
            this.checkBox1.TabIndex = 78;
            this.checkBox1.Text = "Auto";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // grp_gestion
            // 
            this.grp_gestion.Controls.Add(this.label15);
            this.grp_gestion.Controls.Add(this.txt_descripcion);
            this.grp_gestion.Controls.Add(this.cmb_prioridad);
            this.grp_gestion.Controls.Add(this.label14);
            this.grp_gestion.Controls.Add(this.cmb_estado);
            this.grp_gestion.Controls.Add(this.label13);
            this.grp_gestion.Controls.Add(this.cmb_motivo);
            this.grp_gestion.Controls.Add(this.label12);
            this.grp_gestion.Location = new System.Drawing.Point(12, 226);
            this.grp_gestion.Name = "grp_gestion";
            this.grp_gestion.Size = new System.Drawing.Size(925, 263);
            this.grp_gestion.TabIndex = 79;
            this.grp_gestion.TabStop = false;
            this.grp_gestion.Text = "DETALLE DE GESTION";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 19);
            this.label15.TabIndex = 7;
            this.label15.Text = "Descripción: ";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(111, 77);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(804, 170);
            this.txt_descripcion.TabIndex = 6;
            // 
            // cmb_prioridad
            // 
            this.cmb_prioridad.FormattingEnabled = true;
            this.cmb_prioridad.Location = new System.Drawing.Point(314, 24);
            this.cmb_prioridad.Name = "cmb_prioridad";
            this.cmb_prioridad.Size = new System.Drawing.Size(150, 27);
            this.cmb_prioridad.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(233, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "Prioridad: ";
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Location = new System.Drawing.Point(769, 24);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(150, 27);
            this.cmb_estado.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(702, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Estado: ";
            // 
            // cmb_motivo
            // 
            this.cmb_motivo.FormattingEnabled = true;
            this.cmb_motivo.Location = new System.Drawing.Point(76, 24);
            this.cmb_motivo.Name = "cmb_motivo";
            this.cmb_motivo.Size = new System.Drawing.Size(150, 27);
            this.cmb_motivo.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Motivo: ";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(69, 43);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(300, 27);
            this.txt_fecha.TabIndex = 80;
            // 
            // frm_proceso_gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.grp_gestion);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grp_cliente);
            this.Controls.Add(this.txt_idGestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_proceso_gestion";
            this.Text = "f ";
            this.Load += new System.EventHandler(this.frm_proceso_gestion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_cliente.ResumeLayout(false);
            this.grp_cliente.PerformLayout();
            this.grp_gestion.ResumeLayout(false);
            this.grp_gestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label Lbl_asignacionPerfiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idGestion;
        private System.Windows.Forms.GroupBox grp_cliente;
        private System.Windows.Forms.TextBox txt_dpi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txt_nomCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fecNac;
        private System.Windows.Forms.TextBox txt_genero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox grp_gestion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_motivo;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_prioridad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label15;
    }
}

