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

namespace MantenimientoBancosExternos
{
    public partial class ConsultaBancosExternos : Form
    {
        DataTable dt_BancosExternos2 = new DataTable();
        Navegador nv = new Navegador();

        public Form frmMDI2;

        public ConsultaBancosExternos(int intUsuarioCodigo, Form frmMDI)
        {
            InitializeComponent();
            Navegador nv2 = new Navegador();
            nv2.getDatos(intUsuarioCodigo, 81540);
            frmMDI2 = frmMDI;

            dt_BancosExternos2 = nv2.cargarDatos("tbl_bancos_externos");
            dt_BancosExternos.DataSource = dt_BancosExternos2;

            DataTable Dt = new DataTable();
            Dt = (DataTable)dt_BancosExternos.DataSource;                  // Se crea un datatable que contenga los datos del data grid

            RPTBancosExternos rp = new RPTBancosExternos();
            nv.getDatosReportes(Dt, rp);
        }

        private void Lbl_asignacionPerfiles_Click(object sender, EventArgs e)
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

        private void dt_BancosExternos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dt_BancosExternos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ingreso_de_BancosExternos frm = new Ingreso_de_BancosExternos(dt_BancosExternos);
            frm.MdiParent = frmMDI2;
            frm.Show();
            Application.DoEvents();
        }
    }
}
