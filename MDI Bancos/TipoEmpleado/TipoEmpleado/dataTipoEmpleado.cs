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

namespace TipoEmpleado
{
    public partial class dataTipoEmpleado : Form
    {

        Navegador nv = new Navegador();
        DataTable dt = new DataTable();
        public Form frmMDI2;

        public dataTipoEmpleado(int codUser, Form frmMDI)
        {
            InitializeComponent();

            Navegador nv2 = new Navegador();
            nv2.getDatos(codUser, 81535);
            frmMDI2 = frmMDI;


            dt = nv2.cargarDatos("tbl_tipo_empleado");
            dt_tipo_empleado.DataSource = dt;



            DataTable Dt = new DataTable();
            Dt = (DataTable)dt_tipo_empleado.DataSource;                  // Se crea un datatable que contenga los datos del data grid

            RPTTempleados rp = new RPTTempleados();
            nv.getDatosReportes(Dt, rp);


        }

        private void dt_tipo_empleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            mantenimientoTipoEmpleado frm = new mantenimientoTipoEmpleado(dt_tipo_empleado);
            frm.MdiParent = frmMDI2;
            frm.Show();
            Application.DoEvents();

           
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dt_tipo_empleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
