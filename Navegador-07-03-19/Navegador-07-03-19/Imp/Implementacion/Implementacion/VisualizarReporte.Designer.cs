namespace Implementacion
{
    partial class VisualizarReporte
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
            this.CrVAplicaciones = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrVAplicaciones
            // 
            this.CrVAplicaciones.ActiveViewIndex = -1;
            this.CrVAplicaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrVAplicaciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrVAplicaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrVAplicaciones.Location = new System.Drawing.Point(0, 0);
            this.CrVAplicaciones.Name = "CrVAplicaciones";
            this.CrVAplicaciones.ShowCloseButton = false;
            this.CrVAplicaciones.ShowLogo = false;
            this.CrVAplicaciones.Size = new System.Drawing.Size(1101, 568);
            this.CrVAplicaciones.TabIndex = 0;
            // 
            // VisualizarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 568);
            this.Controls.Add(this.CrVAplicaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VisualizarReporte";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualizarReporte";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CrVAplicaciones;
    }
}