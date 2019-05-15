using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaLogicaOperacionesInternas;


namespace OperacionesInternas
{
    public partial class TransferenciaCuentas : Form
    {
        LogicaOperacionesInternas lg = new LogicaOperacionesInternas();
        Class1 cn = new Class1();

        private void cargarEmpleados()
        {
            cbo_Empleado.DataSource = lg.getEmpleados().Tables["emp"].DefaultView;
            cbo_Empleado.DisplayMember = "empleados";
        }

        private void cargarCuentas()
        {
            cbo_CuentaOrigen.DataSource = lg.getCuentas().Tables[0];
            cbo_CuentaOrigen.DisplayMember = "name";
            cbo_CuentaOrigen.ValueMember = "numero_de_cuenta";


            cbo_CuentaDestino.DataSource = lg.getCuentas().Tables[0];
            cbo_CuentaDestino.DisplayMember = "name";
            cbo_CuentaDestino.ValueMember = "numero_de_cuenta";
        }

        private void cargarTipoTransferencia()
        {
            cbo_tipoTrans.DataSource = lg.getTipoTransferencia().Tables[0];
            cbo_tipoTrans.DisplayMember = "name";
            cbo_tipoTrans.ValueMember = "nombre";
        }

        


        public TransferenciaCuentas()
        {
            InitializeComponent();

            //CARGAS COMBOBOX
            cargarEmpleados();
            cargarCuentas();
            cargarTipoTransferencia();

            cbo_Empleado.SelectedIndex = -1;
            cbo_CuentaOrigen.SelectedIndex = -1;
            cbo_CuentaDestino.SelectedIndex = -1;
            cbo_tipoTrans.SelectedIndex = -1;
            //

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
            cbo_CuentaDestino.Enabled = false;
            cbo_Empleado.Enabled = false;
            cbo_tipoTrans.Enabled = false;
            txt_Nota.Enabled = false;

        }

        private void enableElements()
        {
            txt_Importe.Enabled = true;
            dtp_Fecha.Enabled = true;
            cbo_CuentaOrigen.Enabled = true;
            cbo_CuentaDestino.Enabled = true;
            cbo_Empleado.Enabled = true;
            cbo_tipoTrans.Enabled = true;
            txt_Nota.Enabled = true;

        }

        private void clearElements()
        {
            txt_Importe.Text = "0";
            cbo_CuentaOrigen.SelectedIndex = -1;
            cbo_CuentaDestino.SelectedIndex = -1;
            cbo_Empleado.SelectedIndex = -1;
            cbo_tipoTrans.SelectedIndex = -1;
            txt_Nota.Text = "";

        }


        private void btn_Next_Click(object sender, EventArgs e)
        {
            pressBtn();
            disableElements();

        }

        
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            enableElements();

            bool sameCuenta = false;

            DateTime fecha = dtp_Fecha.Value;
            string sFecha = fecha.Year + "-" + fecha.Month + "-" + fecha.Day;

            int cuentaOrigenId = lg.getCuentaId(cbo_CuentaOrigen.Text.ToString());
            int cuentaDestinoId = lg.getCuentaId(cbo_CuentaDestino.Text.ToString());
            int tipoTransferenciaId = lg.getTipoTransferenciaId(cbo_tipoTrans.Text.ToString());
            string tipoMovimiento = cbo_tipoTrans.Text.ToString();
            string nota = txt_Nota.Text.ToString();
            int importe = Convert.ToInt32(txt_Importe.Text.ToString());
            string empleado = cbo_Empleado.Text.ToString();


            int value = Convert.ToInt32(txt_Importe.Text);


            if (Equals(cbo_CuentaOrigen.Text.ToString(), cbo_CuentaDestino.Text.ToString()))
            {
                sameCuenta = true;
            }
            

            if (value < 1)
            {
                MessageBox.Show("Error, el importe debe ser mayor a 0");
                enableElements();
                visibleOptions();

            }
            else if (sameCuenta)
            {
                MessageBox.Show("Error, no se puede realizar una transferencia a la misma cuenta");
                enableElements();
                visibleOptions();
                clearElements();
            }
            else
            {
                if (lg.realizarTransferencia(cuentaOrigenId, cuentaDestinoId, tipoTransferenciaId, sFecha, empleado, tipoMovimiento, nota, importe))
                {
                    MessageBox.Show("Transferencia realizada con exito");
                    clearElements();
                    visibleOptions();
                }
                else
                {
                    MessageBox.Show("Error al realizar transferencia, porfavor verificar fondos de cuenta");
                    clearElements();
                    visibleOptions();
                }
            }
            


           


        }



            private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            enableElements();
            visibleOptions();

        }

        private void txt_Importe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearElements();
        }

        private void cbo_CuentaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Cuenta.Text = Convert.ToString(lg.getCuentaId(cbo_CuentaOrigen.Text.ToString()));
        }

        private void cbo_CuentaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_CuentaOrg.Text = Convert.ToString(lg.getCuentaId(cbo_CuentaDestino.Text.ToString()));
        }

        private void cbo_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(cbo_Empleado.Text))
            {
                //txt_Empleado.Text = Convert.ToString(lg.getEmpleadoId(cbo_Empleado.Text.ToString()));
            }

            //txt_Empleado.Text = Convert.ToString(lg.getEmpleadoId(cbo_Empleado.Text.ToString()));
        }

        private void cbo_tipoTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_tipoTrans.Text = Convert.ToString(lg.getTipoTransferenciaId(cbo_tipoTrans.Text.ToString()));
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txt_Empleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransferenciaCuentas_Load(object sender, EventArgs e)
        {

        }
    }
}
