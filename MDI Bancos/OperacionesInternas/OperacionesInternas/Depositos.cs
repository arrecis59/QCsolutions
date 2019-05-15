using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaOperacionesInternas;

namespace OperacionesInternas
{
    public partial class Depositos : Form
    {

        CapaLogicaOperacionesInternas.LogicaDepositos lg = new CapaLogicaOperacionesInternas.LogicaDepositos();


        public void cargarCuentas()
        {
            cbo_CuentaDestino.DataSource = lg.getCuentas().Tables[0];
            cbo_CuentaDestino.DisplayMember = "name";
            cbo_CuentaDestino.ValueMember = "numero_de_cuenta";

            cbo_CuentaDestino.SelectedIndex = -1;
        }


        public void cargarTiposPago()
        {
            cbo_TipoPago.DataSource = lg.getTipoPago().Tables[0];
            cbo_TipoPago.DisplayMember = "name";
            cbo_TipoPago.ValueMember = "descripcion";

            cbo_TipoPago.SelectedIndex = -1;
        }


        public Depositos()
        {
            InitializeComponent();
            cargarCuentas();
            cargarTiposPago();


        }


        private void pressBtn()
        {
            btn_aceptar.Visible = true;
            btn_Cancelar.Visible = true;
            btn_Clear.Visible = false;
            btn_Next.Visible = false;
            label9.Visible = true;
            pictureBox2.Visible = true;
        }

        private void visibleOptions()
        {
            btn_aceptar.Visible = false;
            btn_Cancelar.Visible = false;
            btn_Clear.Visible = true;
            btn_Next.Visible = true;
            label9.Visible = false;
            pictureBox2.Visible = false;
        }

        private void disableElements()
        {
            txt_Importe.Enabled = false;
            dtp_Fecha.Enabled = false;
            cbo_CuentaDestino.Enabled = false;


        }

        private void enableElements()
        {
            txt_Importe.Enabled = true;
            dtp_Fecha.Enabled = true;
            cbo_CuentaDestino.Enabled = true;

        }

        private void clearElements()
        {
            txt_Importe.Text = "0";
            cbo_CuentaDestino.SelectedIndex = -1;
            cbo_TipoPago.SelectedIndex = -1;

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            enableElements();


            DateTime fecha = dtp_Fecha.Value;
            string sFecha = fecha.Year.ToString() + "-" + fecha.Month.ToString() + "-" + fecha.Day.ToString();

            int cuentaID = lg.getCuentaId(cbo_CuentaDestino.Text.ToString());
            int tipoPagoId = lg.getTipoPagoId(cbo_TipoPago.Text.ToString());
            int importe = Convert.ToInt32(txt_Importe.Text.ToString());

            bool verifyA = false, verifyB = false;


            //OPERACIONES
            if (lg.ajusteCuentas(cuentaID, importe))
            {

                verifyA = true;

                if (lg.registrarMovimiento("Deposito", importe, sFecha, cuentaID, tipoPagoId))
                {
                    verifyB = true;
                }
            }


            //VERIFICACION
            if (verifyA && verifyB)
            {
                MessageBox.Show("Deposito realizado correctamente");
                visibleOptions();
                clearElements();
            }
            else
            {
                MessageBox.Show("Error al realizar el deposito");
                clearElements();
                visibleOptions();
            }

            clearElements();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            enableElements();
            visibleOptions();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            pressBtn();
            disableElements();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearElements();
        }

        private void cbo_CuentaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbo_CuentaDestino.Text))
            {
                txt_Cuenta.Text = Convert.ToString(lg.getCuentaId(cbo_CuentaDestino.Text.ToString()));
            }
        }

        private void cbo_TipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbo_TipoPago.Text))
            {
                txt_TipoPago.Text = Convert.ToString(lg.getTipoPagoId(cbo_TipoPago.Text.ToString()));
            }
        }
    }
}
