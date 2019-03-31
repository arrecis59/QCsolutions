using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaOperacionesExternas;

namespace OperacionesExternas.OperacionExterna
{
    public partial class ConsultaDeSolicitudes : Form
    {
        public ConsultaDeSolicitudes()
        {
            InitializeComponent();
        }

        private void ConsultaDeSolicitudes_Load(object sender, EventArgs e)
        {
            DataSet ds;
            LogicaOperacionesExternas cpl = new LogicaOperacionesExternas();
            ds = cpl.CargarDataGridSolicitudesOpeExternas();
            dt_SolicitudesConciliacion.DataSource = ds.Tables[0];
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
