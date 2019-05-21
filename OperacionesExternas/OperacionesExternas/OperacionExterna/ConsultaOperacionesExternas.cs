using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaOperacionesExternas;

namespace OperacionesExternas.OperacionExterna
{
    public partial class ConsultaOperacionesExternas : Form
    {
        public ConsultaOperacionesExternas()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int opcion = 1;
            if(cbo_OpcionesBusqueda.Text == "Codigo:")
            {
                opcion = 1;
            }else if (cbo_OpcionesBusqueda.Text == "Cuenta:")
            {
                opcion = 2;
            }
            else if(cbo_OpcionesBusqueda.Text == "Beneficiario Externo:")
            {
                opcion = 3;
            }else if (cbo_OpcionesBusqueda.Text == "Agencia:")
            {
                opcion = 4;
            }
            DataSet ds;
            LogicaOperacionesExternas cpl = new LogicaOperacionesExternas();
            ds = cpl.CargarDataGridOperacionesExternas(textBox4.Text, opcion);
            dt_OperacionesExternas.DataSource = ds.Tables[0];
        }

        private void ConsultaOperacionesExternas_Load(object sender, EventArgs e)
        {
            int opcion = 1;
            DataSet ds;
            LogicaOperacionesExternas cpl = new LogicaOperacionesExternas();
            ds = cpl.CargarDataGridOperacionesExternas("", opcion);
            dt_OperacionesExternas.DataSource = ds.Tables[0];
        }
    }
}
