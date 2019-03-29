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
        public Form frmMDI2;


        public empleadoData(int userCode, Form frmMDI)
        {
            InitializeComponent();

            nv.getDatos(userCode, 81530);

            frmMDI2 = frmMDI;

            dt = nv.cargarDatos("tbl_empleado");
            dt_datosEmpleado.DataSource = dt;


            //Reporte
            DataTable Dt = new DataTable();
            Dt = (DataTable)dt_datosEmpleado.DataSource;                  

            RPTEmpleados rp = new RPTEmpleados();
            nv.getDatosReportes(Dt, rp);


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
            empleadoMantenimiento frm = new empleadoMantenimiento(dt_datosEmpleado);
            frm.MdiParent = frmMDI2;
            frm.Show();
            Application.DoEvents();
        }
    }
}
