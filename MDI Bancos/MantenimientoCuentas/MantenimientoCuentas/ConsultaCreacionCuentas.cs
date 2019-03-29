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

namespace MantenimientoCuentas
{
    public partial class ConsultaCreacionCuentas : Form
    {
        DataTable dt_Cuentas2 = new DataTable();
        Navegador nv = new Navegador();

        public Form frmMDI2;

        public ConsultaCreacionCuentas(int intUsuarioCodigo, Form frmMDI)
        {
            InitializeComponent();
            Navegador nv2 = new Navegador();
            nv2.getDatos(intUsuarioCodigo, 81595);
            frmMDI2 = frmMDI;

            dt_Cuentas2 = nv2.cargarDatos("tbl_cuenta");
            dt_Cuentas.DataSource = dt_Cuentas2;

            DataTable Dt = new DataTable();
            Dt = (DataTable)dt_Cuentas.DataSource;                  // Se crea un datatable que contenga los datos del data grid


            RPTCreaciondeCuentas rp = new RPTCreaciondeCuentas();
            nv.getDatosReportes(Dt, rp);


        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void dt_Cuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IngresoDeCuentas frm = new IngresoDeCuentas(dt_Cuentas);
            frm.MdiParent = frmMDI2;
            frm.Show();
            Application.DoEvents();
        }
    }
}
