using System;
using System.Windows.Forms;

namespace CapaDatosGestion
{
    public partial class IngresarGestion : Form
    {
        
        public IngresarGestion()
        {
            InitializeComponent();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_GenerarGestion_Click(object sender, EventArgs e)
        {
            
        }
    }
}
