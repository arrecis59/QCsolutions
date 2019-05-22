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
            DataSet ds = TransaccionGestion.llenarDataGridPen();
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

        private void dgv_gestion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string tmp = dgv_gestion.Rows[e.RowIndex].Cells[0].Value.ToString();
            frm_proceso_gestion tmpForm = new frm_proceso_gestion(Convert.ToInt32(tmp));
            tmpForm.Show();

            Application.DoEvents();
        }

        private void rbtn_pendiente_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds = TransaccionGestion.llenarDataGridPen();
            dgv_gestion.Refresh();
            dgv_gestion.DataSource = ds.Tables[0];
            dgv_gestion.Refresh();
        }
        
        private void rbtn_solucionados_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds = TransaccionGestion.llenarDataGridSol();
            dgv_gestion.Refresh();
            dgv_gestion.DataSource = ds.Tables[0];
            dgv_gestion.Refresh();
        }
    }
}
