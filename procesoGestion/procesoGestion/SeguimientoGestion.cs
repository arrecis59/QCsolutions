using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procesoGestion
{
    public partial class SeguimientoGestion : Form
    {
        public SeguimientoGestion()
        {
            InitializeComponent();
        }

        private void SeguimientoGestion_Load(object sender, EventArgs e)
        {
            DataSet ds = TransaccionGestion.llenarDataGrid();
            dgv_gestion.DataSource = ds.Tables[0];
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
