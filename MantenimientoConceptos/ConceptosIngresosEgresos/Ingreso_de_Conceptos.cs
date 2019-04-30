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

namespace ConceptosIngresosEgresos
{
    public partial class Ingreso_de_Conceptos : Form
    {
        private Navegador navegador = new Navegador();
        private Form frm_consulta_proceso;

        public Ingreso_de_Conceptos(DataGridView dataGridView)
        {
            InitializeComponent();

            navegador.nombreForm(this);
            navegador.dgv_datos(dataGridView);
            navegador.ingresarTabla("tbl_conceptos_flujo_efectivo");
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ConsultaConceptos(int codUsuario, int codModulo, Form frm_consulta_proceso)
        {
            this.frm_consulta_proceso = frm_consulta_proceso;
            Navegador tmp_nvg = new Navegador();

            tmp_nvg.getDatos(codUsuario, codModulo);
            dgv_conceptos.DataSource = tmp_nvg.cargarDatos("tbl_conceptos_flujo_efectivo");

            //DataTable para el reporte.
            DataTable tmp_dt = new DataTable();
            tmp_dt = (DataTable)dgv_conceptos.DataSource;

            RPTConcepto rpt = new RPTConcepto();
            navegador.getDatosReportes(tmp_dt, rpt);
            
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void txt_Estado_TextChanged(object sender, EventArgs e)
        {
            txt_Estado.Text = "1";
        }

        private void dgv_conceptos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ingreso_de_Conceptos tmp_frm = new Ingreso_de_Conceptos(dgv_conceptos);
            tmp_frm.MdiParent = this.frm_consulta_proceso;
            tmp_frm.Show();
            Application.DoEvents();
        }
    }
}
