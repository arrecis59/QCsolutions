namespace MDI_Bancos
{
    partial class BankMDI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankMDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarAplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_barraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.ptb_logoEmpresa = new System.Windows.Forms.PictureBox();
            this.pnl_Fecha = new System.Windows.Forms.Panel();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_Usuario = new System.Windows.Forms.Panel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_DatosUsuario = new System.Windows.Forms.Panel();
            this.pnl_Hora = new System.Windows.Forms.Panel();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.almacenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeTransferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnl_barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logoEmpresa)).BeginInit();
            this.pnl_Fecha.SuspendLayout();
            this.pnl_Usuario.SuspendLayout();
            this.pnl_DatosUsuario.SuspendLayout();
            this.pnl_Hora.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.catalogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1054, 27);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarAplicacionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarAplicacionesToolStripMenuItem
            // 
            this.cerrarAplicacionesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cerrarAplicacionesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cerrarAplicacionesToolStripMenuItem.Name = "cerrarAplicacionesToolStripMenuItem";
            this.cerrarAplicacionesToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.cerrarAplicacionesToolStripMenuItem.Text = "Cerrar Aplicaciones";
            this.cerrarAplicacionesToolStripMenuItem.Click += new System.EventHandler(this.cerrarAplicacionesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.almacenesToolStripMenuItem,
            this.tiposDeTransferenciaToolStripMenuItem});
            this.catalogosToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procesosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.herramientasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(109, 23);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // pnl_barraTitulo
            // 
            this.pnl_barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnl_barraTitulo.Controls.Add(this.pictureBox1);
            this.pnl_barraTitulo.Controls.Add(this.lbl_titulo);
            this.pnl_barraTitulo.Controls.Add(this.btn_minimizar);
            this.pnl_barraTitulo.Controls.Add(this.btn_cerrar);
            this.pnl_barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_barraTitulo.Name = "pnl_barraTitulo";
            this.pnl_barraTitulo.Size = new System.Drawing.Size(1054, 30);
            this.pnl_barraTitulo.TabIndex = 11;
            this.pnl_barraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_barraTitulo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(36, 6);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(56, 19);
            this.lbl_titulo.TabIndex = 4;
            this.lbl_titulo.Text = "Bancos";
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_minimizar.Location = new System.Drawing.Point(836, 0);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(30, 30);
            this.btn_minimizar.TabIndex = 3;
            this.btn_minimizar.Text = "_";
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_cerrar.Location = new System.Drawing.Point(878, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(30, 30);
            this.btn_cerrar.TabIndex = 2;
            this.btn_cerrar.Text = "x";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // ptb_logoEmpresa
            // 
            this.ptb_logoEmpresa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_logoEmpresa.BackgroundImage")));
            this.ptb_logoEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_logoEmpresa.Location = new System.Drawing.Point(0, 327);
            this.ptb_logoEmpresa.Name = "ptb_logoEmpresa";
            this.ptb_logoEmpresa.Size = new System.Drawing.Size(150, 150);
            this.ptb_logoEmpresa.TabIndex = 13;
            this.ptb_logoEmpresa.TabStop = false;
            // 
            // pnl_Fecha
            // 
            this.pnl_Fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnl_Fecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Fecha.Controls.Add(this.lbl_fecha);
            this.pnl_Fecha.Controls.Add(this.label3);
            this.pnl_Fecha.Location = new System.Drawing.Point(500, 0);
            this.pnl_Fecha.Name = "pnl_Fecha";
            this.pnl_Fecha.Size = new System.Drawing.Size(250, 25);
            this.pnl_Fecha.TabIndex = 1;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(50, 3);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(13, 13);
            this.lbl_fecha.TabIndex = 10;
            this.lbl_fecha.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha:";
            // 
            // pnl_Usuario
            // 
            this.pnl_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnl_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Usuario.Controls.Add(this.lbl_usuario);
            this.pnl_Usuario.Controls.Add(this.label2);
            this.pnl_Usuario.Location = new System.Drawing.Point(0, 0);
            this.pnl_Usuario.Name = "pnl_Usuario";
            this.pnl_Usuario.Size = new System.Drawing.Size(500, 25);
            this.pnl_Usuario.TabIndex = 0;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(59, 3);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(13, 13);
            this.lbl_usuario.TabIndex = 9;
            this.lbl_usuario.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario:";
            // 
            // pnl_DatosUsuario
            // 
            this.pnl_DatosUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnl_DatosUsuario.Controls.Add(this.pnl_Hora);
            this.pnl_DatosUsuario.Controls.Add(this.pnl_Fecha);
            this.pnl_DatosUsuario.Controls.Add(this.pnl_Usuario);
            this.pnl_DatosUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_DatosUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_DatosUsuario.Location = new System.Drawing.Point(0, 475);
            this.pnl_DatosUsuario.Name = "pnl_DatosUsuario";
            this.pnl_DatosUsuario.Size = new System.Drawing.Size(1054, 25);
            this.pnl_DatosUsuario.TabIndex = 12;
            // 
            // pnl_Hora
            // 
            this.pnl_Hora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnl_Hora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Hora.Controls.Add(this.lbl_hora);
            this.pnl_Hora.Controls.Add(this.label4);
            this.pnl_Hora.Location = new System.Drawing.Point(750, 0);
            this.pnl_Hora.Name = "pnl_Hora";
            this.pnl_Hora.Size = new System.Drawing.Size(250, 25);
            this.pnl_Hora.TabIndex = 7;
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Location = new System.Drawing.Point(43, 3);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(13, 13);
            this.lbl_hora.TabIndex = 11;
            this.lbl_hora.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hora:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // almacenesToolStripMenuItem
            // 
            this.almacenesToolStripMenuItem.Name = "almacenesToolStripMenuItem";
            this.almacenesToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.almacenesToolStripMenuItem.Text = "Agencias";
            this.almacenesToolStripMenuItem.Click += new System.EventHandler(this.almacenesToolStripMenuItem_Click);
            // 
            // tiposDeTransferenciaToolStripMenuItem
            // 
            this.tiposDeTransferenciaToolStripMenuItem.Name = "tiposDeTransferenciaToolStripMenuItem";
            this.tiposDeTransferenciaToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.tiposDeTransferenciaToolStripMenuItem.Text = "Tipos de Transferencia";
            this.tiposDeTransferenciaToolStripMenuItem.Click += new System.EventHandler(this.tiposDeTransferenciaToolStripMenuItem_Click);
            // 
            // BankMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1054, 500);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_barraTitulo);
            this.Controls.Add(this.ptb_logoEmpresa);
            this.Controls.Add(this.pnl_DatosUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "BankMDI";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_barraTitulo.ResumeLayout(false);
            this.pnl_barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logoEmpresa)).EndInit();
            this.pnl_Fecha.ResumeLayout(false);
            this.pnl_Fecha.PerformLayout();
            this.pnl_Usuario.ResumeLayout(false);
            this.pnl_Usuario.PerformLayout();
            this.pnl_DatosUsuario.ResumeLayout(false);
            this.pnl_Hora.ResumeLayout(false);
            this.pnl_Hora.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarAplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_barraTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.PictureBox ptb_logoEmpresa;
        private System.Windows.Forms.Panel pnl_Fecha;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_Usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_DatosUsuario;
        private System.Windows.Forms.Panel pnl_Hora;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem almacenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeTransferenciaToolStripMenuItem;
    }
}

