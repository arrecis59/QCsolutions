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
    public partial class IngresoTipoDeCambio : Form
    {
        Navegador nv = new Navegador();
        public IngresoTipoDeCambio(DataGridView dgv)
        {
            InitializeComponent();

            nv.nombreForm(this);
            nv.dgv_datos(dgv);

            nv.ingresarTabla("tbl_tipo_cambio");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IngresoTipoDeCambio_Load(object sender, EventArgs e)
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
    }
}
