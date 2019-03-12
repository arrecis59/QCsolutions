namespace DLL__Reporteador
{
    partial class VistaPrevia
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
            this.CrVVistaPrevia = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CrVVistaPrevia
            // 
            this.CrVVistaPrevia.ActiveViewIndex = -1;
            this.CrVVistaPrevia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrVVistaPrevia.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrVVistaPrevia.Location = new System.Drawing.Point(12, 12);
            this.CrVVistaPrevia.Name = "CrVVistaPrevia";
            this.CrVVistaPrevia.Size = new System.Drawing.Size(844, 475);
            this.CrVVistaPrevia.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(862, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(103, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // VistaPrevia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 519);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CrVVistaPrevia);
            this.Name = "VistaPrevia";
            this.Text = "VistaPrevia";
            this.Load += new System.EventHandler(this.VistaPrevia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CrVVistaPrevia;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}