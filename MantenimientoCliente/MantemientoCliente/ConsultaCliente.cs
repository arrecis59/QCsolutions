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

namespace MantemientoCliente
{
    public partial class ConsultaCliente : Form
    {
        //private Navegador navegador = new Navegador(); En espera del reporteador.
        private Form frm_consulta_proceso;

        public ConsultaCliente(int codUsuario, Form frm_consulta_proceso)
        {
            InitializeComponent();
            this.frm_consulta_proceso = frm_consulta_proceso;

            Navegador tmp_navegador = new Navegador();

            tmp_navegador.getDatos(codUsuario, 81561);
            dgv_cliente.DataSource = tmp_navegador.cargarDatos("tbl_cliente");

            //DataTable para el reporteador.
            //DataTable tmp_dt = new DataTable();
            //tmp_dt = (DataTable)dgv_Conceptos.DataSource;

            //RPTCliente rpt = new RPTCliente();
            //navegador.getDatosReportes(tmp_dt, rpt);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgv_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ingreso_de_Cliente tmp_frm = new Ingreso_de_Cliente(dgv_cliente);
            tmp_frm.MdiParent = this.frm_consulta_proceso;
            tmp_frm.Show();
            Application.DoEvents();
        }
    }
}
