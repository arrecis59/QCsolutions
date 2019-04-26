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
    
    public partial class Ingreso_de_Cliente : Form
    {
        Navegador navegador = new Navegador();
        private Form frm_consulta_proceso;

        public Ingreso_de_Cliente(DataGridView dgv)
        {
            InitializeComponent();

            navegador.nombreForm(this);
            navegador.dgv_datos(dgv);
            navegador.ingresarTabla("tbl_cliente");
        }

        public void consultaCliente(int codUsuario, Form frm_consulta_proceso)
        {
            Navegador tmp_nvg = new Navegador();
            this.frm_consulta_proceso = frm_consulta_proceso;

            tmp_nvg.getDatos(codUsuario, 81561);
            dgv_cliente.DataSource = tmp_nvg.cargarDatos("tbl_cliente");

            //DatTabla para el reporte
            DataTable tmp_dt = new DataTable();
            tmp_dt = (DataTable)dgv_cliente.DataSource;

            RPTCliente rpt = new RPTCliente();
            navegador.getDatosReportes(tmp_dt, rpt);
        }

        private void dgv_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ingreso_de_Cliente tmp_frm = new Ingreso_de_Cliente(dgv_cliente);
            tmp_frm.MdiParent = this.frm_consulta_proceso;
            tmp_frm.Show();
            Application.DoEvents();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {
            txt_estado.Text = "1";
        }
    }
}
