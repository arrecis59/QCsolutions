using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;

namespace Empleado
{
    public partial class empleadoData : Form
    {

        Navegador nv = new Navegador();
        DataTable dt = new DataTable();
       

        public empleadoData(int userCode, Form MDI)
        {
            InitializeComponent();

            nv.getDatos(userCode, 50000);

            dt = nv.cargarDatos("tbl_empleado");
            dt_datosEmpleado.DataSource = dt;

        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dt_datosEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new empleadoMantenimiento(dt_datosEmpleado).Show();
        }
    }
}
