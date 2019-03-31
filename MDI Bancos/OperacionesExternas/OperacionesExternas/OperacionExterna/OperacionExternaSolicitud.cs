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
    public partial class OperacionExternaSolicitud : Form
    {
        static Form frm;
        public OperacionExternaSolicitud(Form frm2)
        {
            InitializeComponent();
            frm = frm2;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            LogicaOperacionesExternas cpl = new LogicaOperacionesExternas();
            cpl.validarNumeros(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_GenerarSolicitud_Click(object sender, EventArgs e)
        {
            string[] datos;
            datos = new string[10];
            datos[0] = txt_codigo.Text;
            datos[1] = dtp_Fecha.Value.Date.ToString("yyyy-MM-dd");
            datos[2] = txt_Importe.Text;
            datos[3] = txt_Nota.Text;
            datos[4] = txt_Cuenta.Text;
            datos[5] = txt_BenExterno.Text;
            datos[6] = txt_Agencia.Text;
            datos[7] = txt_Empleado.Text;
            datos[8] = cbo_Estado.Text;
            datos[9] = txt_Status.Text;

            ConfirmarSolicitudOperacionesExternas cso = new ConfirmarSolicitudOperacionesExternas(datos);
            cso.MdiParent = frm;
            cso.Show();
            Application.DoEvents();

            //LogicaOperacionesExternas cpl = new LogicaOperacionesExternas();
            //cpl.validacionInsertarOperacioensExternas("tbl_transferencia_externa", txt_codigo.Text, dtp_Fecha.Value.Date.ToString("yyyy-MM-dd"), txt_Importe.Text, txt_Nota.Text, txt_Cuenta.Text, txt_BenExterno.Text, txt_Agencia.Text, txt_Empleado.Text, cbo_Estado.Text, txt_Status.Text);
        }
    }
}
