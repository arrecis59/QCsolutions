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
    public partial class dataEmpleado : Form
    {

        Navegador nv = new Navegador();
        DataTable dt = new DataTable();

        public dataEmpleado(int codeUser, Form MDIform)
        {
            InitializeComponent();

            nv.getDatos(codeUser, 40000);

            dt = nv.cargarDatos("tbl_empleado");
            dt_empleado.DataSource = dt;



        }

        private void dt_empleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new mantenimientoEmpleado(dt_empleado).Show();
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
