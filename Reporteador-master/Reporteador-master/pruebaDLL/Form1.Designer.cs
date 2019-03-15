namespace pruebaDLL
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dSPrueba = new pruebaDLL.DSPrueba();
            this.dSPruebaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLLeno = new pruebaDLL.DsLLeno();
            this.dsLLenoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLLeno1 = new pruebaDLL.DsLLeno();
            this.dsLLeno1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPrueba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPruebaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLLeno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLLenoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLLeno1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLLeno1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Administrador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Abrir Rpt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Administrador";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dSPrueba
            // 
            this.dSPrueba.DataSetName = "DSPrueba";
            this.dSPrueba.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSPruebaBindingSource
            // 
            this.dSPruebaBindingSource.DataSource = this.dSPrueba;
            this.dSPruebaBindingSource.Position = 0;
            // 
            // dsLLeno
            // 
            this.dsLLeno.DataSetName = "DsLLeno";
            this.dsLLeno.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsLLenoBindingSource
            // 
            this.dsLLenoBindingSource.DataSource = this.dsLLeno;
            this.dsLLenoBindingSource.Position = 0;
            // 
            // dsLLeno1
            // 
            this.dsLLeno1.DataSetName = "DsLLeno";
            this.dsLLeno1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsLLeno1BindingSource
            // 
            this.dsLLeno1BindingSource.DataSource = this.dsLLeno1;
            this.dsLLeno1BindingSource.Position = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(232, 332);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(480, 150);
            this.dataGridView2.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Administrador";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(358, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(219, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Administrador";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 519);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPrueba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPruebaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLLeno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLLenoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLLeno1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLLeno1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private DSPrueba dSPrueba;
        private System.Windows.Forms.BindingSource dSPruebaBindingSource;
        private System.Windows.Forms.BindingSource dsLLenoBindingSource;
        private DsLLeno dsLLeno;
        private System.Windows.Forms.BindingSource dsLLeno1BindingSource;
        private DsLLeno dsLLeno1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

