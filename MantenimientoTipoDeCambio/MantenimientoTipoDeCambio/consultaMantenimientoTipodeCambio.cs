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

namespace MantenimientoTipoDeCambio
{
    public partial class consultaMantenimientoTipodeCambio : Form
    {
        DataTable dt_TipoDeCambio2 = new DataTable();
        Navegador nv = new Navegador();

        public Form frmMDI2;

        public consultaMantenimientoTipodeCambio(int intUsuarioCodigo, Form frmMDI)
        {
            InitializeComponent();
            Navegador nv2 = new Navegador();
            nv2.getDatos(intUsuarioCodigo, 81510);
            frmMDI2 = frmMDI;

            dt_TipoDeCambio2 = nv2.cargarDatos("tbl_tipo_cambio");
            dt_TipoDeCambio.DataSource = dt_TipoDeCambio2;

            DataTable Dt = new DataTable();
            Dt = (DataTable)dt_TipoDeCambio.DataSource;                  // Se crea un datatable que contenga los datos del data grid

            rptTipoDeCambio rp = new rptTipoDeCambio();
            nv.getDatosReportes(Dt, rp);
        }

        private void consulta_Load(object sender, EventArgs e)
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

        private void dt_TipoDeCambio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IngresoTipoDeCambio frm = new IngresoTipoDeCambio(dt_TipoDeCambio);
            frm.MdiParent = frmMDI2;
            frm.Show();
            Application.DoEvents();
        }
    }
}
