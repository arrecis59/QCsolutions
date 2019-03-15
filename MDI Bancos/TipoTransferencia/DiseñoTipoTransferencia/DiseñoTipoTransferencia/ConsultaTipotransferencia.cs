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


namespace DiseñoTipoTransferencia
{
    public partial class ConsultaTipotransferencia : Form
    {
        DataTable dt_TipoTransferencia2 = new DataTable();
        Navegador nv = new Navegador();

        public Form frmMDI2;

        public ConsultaTipotransferencia(int intUsuarioCodigo, Form frmMDI)
        {
            InitializeComponent();
            Navegador nv2 = new Navegador();
            nv2.getDatos(intUsuarioCodigo, 81550);
            frmMDI2 = frmMDI;

            dt_TipoTransferencia2 = nv2.cargarDatos("tbl_tipo_transferencia");
            dt_TipoTransferencia.DataSource = dt_TipoTransferencia2;

            DataTable Dt = new DataTable();
            Dt = (DataTable)dt_TipoTransferencia.DataSource;                  // Se crea un datatable que contenga los datos del data grid

            RPTTipoTransferencia rp = new RPTTipoTransferencia();
            nv.getDatosReportes(Dt, rp);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dt_TipoTransferencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IngresoTipoTransferencia frm = new IngresoTipoTransferencia(dt_TipoTransferencia);
            frm.MdiParent = frmMDI2;
            frm.Show();
            Application.DoEvents();
        }
    }
}
