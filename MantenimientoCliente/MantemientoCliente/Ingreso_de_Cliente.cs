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
        public Ingreso_de_Cliente(DataGridView dgv)
        {
            InitializeComponent();

            navegador.nombreForm(this);
            navegador.dgv_datos(dgv);
            navegador.ingresarTabla("tbl_cliente");
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
