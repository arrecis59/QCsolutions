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

namespace MantenimientoAgencias
{
    public partial class ConsultaAgencias : Form
    {
        DataTable dt_Agencia2 = new DataTable();
        Navegador nv = new Navegador();

        public Form frmMDI2;

        public ConsultaAgencias(int intUsuarioCodigo, Form frmMDI)
        {
            InitializeComponent();
            Navegador nv2 = new Navegador();
            nv2.getDatos(intUsuarioCodigo, 81540);
            frmMDI2 = frmMDI;

            dt_Agencia2 = nv2.cargarDatos("tbl_agencia");
            dt_Agencias.DataSource = dt_Agencia2;

            DataTable Dt = new DataTable();
            Dt = (DataTable)dt_Agencias.DataSource;                  // Se crea un datatable que contenga los datos del data grid

            RPTAgencia rp = new RPTAgencia();
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

        private void ConsultaAgencias_Load(object sender, EventArgs e)
        {

        }

        private void dt_Agencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ingreso_de_Agencias frm = new Ingreso_de_Agencias(dt_Agencias);
            frm.MdiParent = frmMDI2;
            frm.Show();
            Application.DoEvents();
        }
    }
}
