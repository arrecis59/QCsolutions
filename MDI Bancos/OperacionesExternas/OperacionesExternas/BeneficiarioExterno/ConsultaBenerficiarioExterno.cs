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

namespace OperacionesExternas
{
    public partial class ConsultaBenerficiarioExterno : Form
    {
        DataTable dt_BeneficiarioExterno = new DataTable();
        Navegador nv = new Navegador();
        public Form frmMDI2;


        public ConsultaBenerficiarioExterno(int intUsuarioCodigo, Form frmMDI)
        {
            InitializeComponent();
            Navegador nv2 = new Navegador();
            nv2.getDatos(intUsuarioCodigo, 81310);                          // Codigo de la aplicacion y usuario para cargar permisos

            dt_BeneficiarioExterno = nv2.cargarDatos("tbl_beneficiario_externo");
            dt_BeneficioExterno.DataSource = dt_BeneficiarioExterno;

            frmMDI2 = frmMDI;
            DataTable Dt = new DataTable();
            Dt = (DataTable)dt_BeneficioExterno.DataSource;                  // Se crea un datatable que contenga los datos del data grid
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dt_BeneficioExterno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BeneficiarioExterno.IngresoBeneficiarioExterno frm = new BeneficiarioExterno.IngresoBeneficiarioExterno(dt_BeneficioExterno);
            frm.MdiParent = frmMDI2;
            frm.Show();
            Application.DoEvents();
        }
    }
}
