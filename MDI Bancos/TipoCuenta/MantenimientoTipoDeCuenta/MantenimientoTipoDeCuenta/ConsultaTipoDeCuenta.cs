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

namespace MantenimientoTipoDeCuenta
{
    public partial class ConsultaTipoDeCuenta : Form
    {
        DataTable dt_TipoDeCuenta2 = new DataTable();
        Navegador nv = new Navegador();

        public Form frmMDI2;

        public ConsultaTipoDeCuenta(int intUsuarioCodigo, Form frmMDI)
        {
            InitializeComponent();
            Navegador nv2 = new Navegador();
            nv2.getDatos(intUsuarioCodigo, 81510);
            frmMDI2 = frmMDI;

            dt_TipoDeCuenta2 = nv2.cargarDatos("tbl_tipo_cuenta");
            dt_TipoDeCuenta.DataSource = dt_TipoDeCuenta2;

            DataTable Dt = new DataTable();
            Dt = (DataTable)dt_TipoDeCuenta.DataSource;                  // Se crea un datatable que contenga los datos del data grid

            RPTTipoDeCuenta rp = new RPTTipoDeCuenta();
            nv.getDatosReportes(Dt, rp);
        }

        private void ConsultaTipoDeCuenta_Load(object sender, EventArgs e)
        {

        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dt_TipoDeCuenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ingreso_de_TipoDeCuenta frm = new Ingreso_de_TipoDeCuenta(dt_TipoDeCuenta);
            frm.MdiParent = frmMDI2;
            frm.Show();
            Application.DoEvents();
        }
    }
}
