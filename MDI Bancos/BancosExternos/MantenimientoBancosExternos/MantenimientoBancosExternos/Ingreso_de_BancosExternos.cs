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
    public partial class Ingreso_de_BancosExternos : Form
    {
        Navegador nv = new Navegador();
        public Ingreso_de_BancosExternos(DataGridView dgv)
        {
            InitializeComponent();
            nv.nombreForm(this);
            nv.dgv_datos(dgv);

            nv.ingresarTabla("tbl_bancos_externos");
        }

        private void txt_Codigo_TextChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
