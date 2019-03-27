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

namespace Manttenimiento_Moneda
{
    public partial class cnsultaMantenimientoMoneda : Form
    {
        DataTable dt_moneda2 = new DataTable();
        Navegador nv = new Navegador();

        public Form frmMDI2;

        public cnsultaMantenimientoMoneda(int intUsuarioCodigo, Form frmMDI)
        {
            InitializeComponent();
            Navegador nv2 = new Navegador();
            nv2.getDatos(intUsuarioCodigo, 81540);
            frmMDI2 = frmMDI;

            dt_moneda2 = nv2.cargarDatos("tbl_moneda");
            dt_moneda.DataSource = dt_moneda2;

            DataTable Dt = new DataTable();
            Dt = (DataTable)dt_moneda.DataSource;                  // Se crea un datatable que contenga los datos del data grid

            rptmoneda rp = new rptmoneda();
            nv.getDatosReportes(Dt, rp);
        }

        private void cnsultaMantenimientoMoneda_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dt_moneda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IngresoMoneda frm = new IngresoMoneda(dt_moneda);
            frm.MdiParent = frmMDI2;
            frm.Show();
            Application.DoEvents();
        }
    }
}
