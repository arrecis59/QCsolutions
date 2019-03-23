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
        Navegador navegador = new Navegador();
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

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void txt_Estado_TextChanged(object sender, EventArgs e)
        {
            txt_Estado.Text = "1";
        }
    }
}
