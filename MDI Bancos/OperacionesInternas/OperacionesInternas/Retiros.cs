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
    public partial class Retiros : Form
    {
        CapaLogicaOperacionesInternas.LogicaRetiros lg = new CapaLogicaOperacionesInternas.LogicaRetiros();

        private void cargarCuentas()
        {
            cbo_CuentaOrigen.DataSource = lg.getCuentas().Tables[0];
            cbo_CuentaOrigen.DisplayMember = "name";
            cbo_CuentaOrigen.ValueMember = "numero_de_cuenta";

           
        }




        public Retiros()
        {
            InitializeComponent();

            //CARGA COMBOBOX
            cargarCuentas();
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
            cbo_CuentaOrigen.Enabled = false;


        }

        private void enableElements()
        {
            txt_Importe.Enabled = true;
            dtp_Fecha.Enabled = true;
            cbo_CuentaOrigen.Enabled = true;

        }

        private void clearElements()
        {
            txt_Importe.Text = "0";
            cbo_CuentaOrigen.SelectedIndex = -1;

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            enableElements();

            DateTime fecha = dtp_Fecha.Value;
            string sFecha = fecha.Year.ToString() + "-" + fecha.Month.ToString() + "-" + fecha.Day.ToString();

            int monto = Convert.ToInt32(txt_Importe.Text.ToString());
            int cuentaID = lg.getCuentaId(cbo_CuentaOrigen.Text.ToString());
            bool successful = false;




            if (lg.verificaFondos(cuentaID, monto))
            {
                if (lg.ajusteCuentas(cuentaID, monto))
                {
                    if (lg.registrarMovimiento("Retiro", monto, sFecha, cuentaID, 1))
                    {
                        successful = true;
                    }
                    else
                    {
                        MessageBox.Show("Error, al realizar el retiro");
                        clearElements();
                        visibleOptions();
                    }
                }
                else
                {
                    MessageBox.Show("Error, al ajustar cuentas");
                    clearElements();
                    visibleOptions();
                }
            }
            else
            {
                MessageBox.Show("Error, fondos insuficientes");
                clearElements();
                visibleOptions();
            }


            if (successful)
            {
                MessageBox.Show("Retiro realizado correctamente");
                visibleOptions();
                clearElements();
            }

            clearElements();
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            enableElements();
            visibleOptions();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cbo_CuentaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbo_CuentaOrigen.Text))
            {
                txt_Cuenta.Text = Convert.ToString(lg.getCuentaId(cbo_CuentaOrigen.Text.ToString()));
            }
        }
    }
}
