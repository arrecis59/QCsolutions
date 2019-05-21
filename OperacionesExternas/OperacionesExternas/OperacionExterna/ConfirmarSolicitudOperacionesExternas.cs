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
    public partial class ConfirmarSolicitudOperacionesExternas : Form
    {
        public ConfirmarSolicitudOperacionesExternas(string[] datos)
        {
            InitializeComponent();
            txt_codigo.Text = datos[0];
            txt_Fecha.Text = datos[1];
            txt_Importe.Text = datos[2];
            txt_Nota.Text = datos[3];
            txt_Cuenta.Text = datos[4];
            txt_BenExterno.Text = datos[5];
            txt_Agencia.Text = datos[6];
            txt_Empleado.Text = datos[7];
            txt_Estado.Text = datos[8];
            txt_Status.Text = datos[9];
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_GenerarSolicitud_Click(object sender, EventArgs e)
        {
            LogicaOperacionesExternas cpl = new LogicaOperacionesExternas();
            cpl.validacionInsertarOperacioensExternas("tbl_transferencia_externa", txt_codigo.Text, txt_Fecha.Text, txt_Importe.Text, txt_Nota.Text, txt_Cuenta.Text, txt_BenExterno.Text, txt_Agencia.Text, txt_Empleado.Text, txt_Estado.Text, txt_Status.Text);
        }
    }
}
