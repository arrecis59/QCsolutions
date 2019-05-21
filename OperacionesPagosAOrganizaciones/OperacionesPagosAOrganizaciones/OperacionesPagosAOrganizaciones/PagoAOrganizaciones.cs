using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiUsos;
using System.Windows.Forms;
using CapaLogicaPagoAOrganizaciones;

namespace OperacionesPagosAOrganizaciones
{
    public partial class PagoAOrganizaciones : Form
    {
        public PagoAOrganizaciones()
        {
            InitializeComponent();
        }

        public static string nCuentaSeleccionada = "";
        public static string orgNombre = "";

        public static bool verificacionCodigo;
        public static bool verificacionImporte;
        public static string newSaldo;      // Variable que almacena el nuevo saldo despues del importe de la cuenta que da
        public static string newSaldo2;      // Variable que almacena el nuevo saldo despues del importe de la cuenta que recibe

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void llenarNCuenta(string nCuenta, string nOrg)
        {
            orgNombre = nOrg;
            nCuentaSeleccionada = nCuenta;
        }

        private void btn_AddBenExterno_Click(object sender, EventArgs e)
        {
            SeleccionDeCuentaOrganizacion form = new SeleccionDeCuentaOrganizacion();
            form.ShowDialog();
            txt_CuentaOrg.Text = nCuentaSeleccionada;
            txt_NombreOrg.Text = orgNombre;
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseDeValidaciones cv = new ClaseDeValidaciones();
            cv.SoloNumeros(sender, e);
        }

        private void txt_Importe_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseDeValidaciones cv = new ClaseDeValidaciones();
            cv.SoloNumeros(sender, e);
        }

        private void PagoAOrganizaciones_Load(object sender, EventArgs e)
        {
            //chb_CodigoTransExt.Checked = true;
            ClaseMultiusos cm = new ClaseMultiusos();
            cm.cargarDatosACombobox(cbo_Cuenta, "numero_de_cuenta", "tbl_cuenta");
            cm.cargarDatosACombobox(cbo_Agencia, "nombre", "tbl_agencia");
            cm.cargarDatosACombobox(cbo_Empleado, "nombre", "tbl_empleado");
            cm.cargarDatosACombobox(cbo_tipoTrans, "nombre", "tbl_tipo_transferencia");
        }

        private void chb_CodigoTransExt_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cbo_Cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_cuenta", "tbl_cuenta", "numero_de_cuenta", cbo_Cuenta.Text);
            txt_Cuenta.Text = codigo;
        }

        private void cbo_Agencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_agencia", "tbl_agencia", "nombre", cbo_Agencia.Text);
            txt_Agencia.Text = codigo;
        }

        private void cbo_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_empleado", "tbl_empleado", "nombre", cbo_Empleado.Text);
            txt_Empleado.Text = codigo;
        }

        private void cbo_tipoTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_tipo_transferencia", "tbl_tipo_transferencia", "nombre", cbo_tipoTrans.Text);
            txt_tipoTrans.Text = codigo;
        }

        private void txt_Importe_TextChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            if (txt_Importe.Text != "")
            {
                int saldo = System.Convert.ToInt32(cm.ExtraerCodigo("saldo", "tbl_cuenta", "id_cuenta", txt_Cuenta.Text));
                int importe = System.Convert.ToInt32(txt_Importe.Text);
                int saldo_2 = System.Convert.ToInt32(cm.ExtraerCodigo("saldo", "tbl_cuenta", "id_cuenta", txt_CuentaOrg.Text));
                LogicaPagoAOrganizaciones loe = new LogicaPagoAOrganizaciones();
                if (saldo <= importe)
                {
                    verificacionImporte = false;
                }
                else
                {
                    verificacionImporte = true;
                    newSaldo = loe.calculoDeNuevoSaldo_1(importe.ToString(), saldo.ToString());
                    newSaldo2 = loe.calculoDeNuevoSaldo_2(importe.ToString(), saldo_2.ToString());
                }
            }
            else if (txt_Importe.Text == "")
            {
                txt_Importe.Text = "0";
            }
            if(txt_Importe.Text == "0")
            {
                verificacionImporte = false;
            }
            else
            {
                verificacionImporte = true;
            }
            verificacionBotones();
        }

        public void verificacionBotones()
        {
            //
            if (verificacionImporte == false)
            {
                pcb_Importe.Visible = true;
            }
            else
            {
                pcb_Importe.Visible = false;
            }

            //

            if (verificacionImporte == false || txt_Importe.Text == "" )
            {
                btn_Next.Enabled = false;
            }
            else
            {
                btn_Next.Enabled = true;
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            txt_Importe.Enabled = false;
            dtp_Fecha.Enabled = false;
            cbo_Cuenta.Enabled = false;
            cbo_Agencia.Enabled = false;
            cbo_Empleado.Enabled = false;
            cbo_tipoTrans.Enabled = false;
            txt_Nota.Enabled = false;
            btn_aceptar.Visible = true;
            btn_Next.Visible = false;
            btn_aceptar.Location = new Point(739, 548);
            btn_Cancelar.Visible = true;
            btn_Clear.Visible = false;
            btn_Cancelar.Location = new Point(644, 548);
            pictureBox2.Visible = true;
            label9.Visible = true;
        }

        public void RegresarAEstadoInicial()
        {
            txt_Importe.Enabled = true;
            dtp_Fecha.Enabled = true;
            cbo_Cuenta.Enabled = true;
            cbo_Agencia.Enabled = true;
            cbo_Empleado.Enabled = true;
            txt_Nota.Enabled = true;
            cbo_tipoTrans.Enabled = true;
            btn_aceptar.Visible = false;
            btn_Next.Visible = true;
            btn_Cancelar.Visible = false;
            btn_Clear.Visible = true;
            pictureBox2.Visible = false;
            label9.Visible = false;
        }

        public void limpiar()
        {
            txt_Importe.Text = "";
            cbo_Cuenta.SelectedIndex = 0;
            cbo_tipoTrans.SelectedIndex = 0;
            cbo_Agencia.SelectedIndex = 0;
            cbo_Empleado.SelectedIndex = 0;
            txt_Nota.Text = "";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            RegresarAEstadoInicial();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            List<string> comandos = new List<string>();
            try
            {
                /*cm.InsertarDatosAplicaciones("tbl_transferencia", "0,'" + dtp_Fecha.Value.ToString("yyyy-MM-dd") + "'," + txt_Importe.Text + ",'" + txt_Nota.Text + "'," + txt_Cuenta.Text + "," + txt_CuentaOrg.Text + "," + txt_Agencia.Text + "," + txt_Empleado.Text + "," + txt_tipoTrans.Text + " , 1");
                cm.InsertarDatosAplicaciones("tbl_movimientos_cuenta", "0, 'Pago a organizaciones'," + txt_Importe.Text + ",'" + dtp_Fecha.Value.ToString("yyyy-MM-dd") + "'," + txt_Cuenta.Text + ",2");
                cm.InsertarDatosAplicaciones("tbl_movimientos_cuenta", "0, 'Ingreso por pago a organizaciones'," + txt_Importe.Text + ",'" + dtp_Fecha.Value.ToString("yyyy-MM-dd") + "'," + txt_CuentaOrg.Text + ",2");
                cm.ModificarDatos("tbl_cuenta", "saldo = " + newSaldo, "id_cuenta", txt_Cuenta.Text);
                cm.ModificarDatos("tbl_cuenta", "saldo = " + newSaldo2, "id_cuenta", txt_CuentaOrg.Text);
               */
                comandos.Add(cm.DevolverSentencia_Insert("tbl_transferencia", "0,'" + dtp_Fecha.Value.ToString("yyyy-MM-dd") + "'," + txt_Importe.Text + ",'" + txt_Nota.Text + "'," + txt_Cuenta.Text + "," + txt_CuentaOrg.Text + "," + txt_Agencia.Text + "," + txt_Empleado.Text + "," + txt_tipoTrans.Text + " , 1"));
                comandos.Add(cm.DevolverSentencia_Insert("tbl_movimientos_cuenta", "0, " + txt_Importe.Text + ",'" + dtp_Fecha.Value.ToString("yyyy-MM-dd") + "',0," + txt_Cuenta.Text + ",2,1"));
                comandos.Add(cm.DevolverSentencia_Insert("tbl_movimientos_cuenta", "0, " + txt_Importe.Text + ",'" + dtp_Fecha.Value.ToString("yyyy-MM-dd") + "',1," + txt_CuentaOrg.Text + ",2,1"));
                comandos.Add(cm.DevolverSentencia_Modificar("tbl_cuenta", "saldo = " + newSaldo, "id_cuenta", txt_Cuenta.Text));
                comandos.Add(cm.DevolverSentencia_Modificar("tbl_cuenta", "saldo = " + newSaldo2, "id_cuenta", txt_CuentaOrg.Text));

                cm.EjectuarOperacionExterna(comandos, "Transferencia a organizacion", "81500");

                MessageBox.Show("Transaccion realizada");
                limpiar();
                RegresarAEstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_Cuenta_TextChanged(object sender, EventArgs e)
        {
            if (txt_Cuenta.Text == txt_CuentaOrg.Text)
            {
                verificacionImporte = false;
            }
            else
            {
                verificacionImporte = true;
            }
        }

        private void txt_CuentaOrg_TextChanged(object sender, EventArgs e)
        {
            if (txt_Cuenta.Text == txt_CuentaOrg.Text)
            {
                verificacionImporte = false;
            }
            else
            {
                verificacionImporte = true;
            }
        }
    }
}
