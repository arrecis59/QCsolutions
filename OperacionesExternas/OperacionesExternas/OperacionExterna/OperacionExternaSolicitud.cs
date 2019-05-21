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
using MultiUsos;
using CreacionDeCuentas;

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

        public static bool verificacionCodigo;
        public static bool verificacionImporte;
        public static string newSaldo;      // Variable que almacena el nuevo saldo despues del importe

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
            ClaseDeValidaciones cv = new ClaseDeValidaciones();
            cv.Decimales(txt_Importe, sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_GenerarSolicitud_Click(object sender, EventArgs e)
        {
        }

        private void OperacionExternaSolicitud_Load(object sender, EventArgs e)
        {
            chb_CodigoTransExt.Checked = true;
            ClaseMultiusos cm = new ClaseMultiusos();
            cm.cargarDatosACombobox(cbo_Cuenta, "numero_de_cuenta", "tbl_cuenta");
            cm.cargarDatosACombobox(cbo_BenExterno, "nombres", "tbl_beneficiario_externo");
            cm.cargarDatosACombobox(cbo_Agencia, "nombre", "tbl_agencia");
            cm.cargarDatosACombobox(cbo_Empleado, "nombre", "tbl_empleado");
        }

        private void chb_CodigoTransExt_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ClaseMultiusos cm = new ClaseMultiusos();
                if (chb_CodigoTransExt.Checked == true)
                {
                    txt_codigo.Text = cm.GenerarAutoCodigo("id_transferencia_externa", "tbl_transferencia_externa");
                }
                else
                {
                    txt_codigo.Text = "";
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void cbo_Cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_cuenta", "tbl_cuenta", "numero_de_cuenta", cbo_Cuenta.Text);
            txt_Cuenta.Text = codigo;
        }

        private void cbo_BenExterno_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_beneficiario_externo", "tbl_beneficiario_externo", "nombres", cbo_BenExterno.Text);
            txt_BenExterno.Text = codigo;
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

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            if (txt_codigo.Text != "")
            {
                if (cm.ValidarExistenciaDeCodigos("tbl_transferencia_externa", "id_transferencia_externa", txt_codigo.Text) == false)
                {
                    verificacionCodigo = false;
                }
                else
                {
                    verificacionCodigo = true;
                }
            }
            verificacionBotones();
        }

        private void txt_Importe_TextChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            if (txt_Importe.Text != "")
            {
                double saldo = System.Convert.ToDouble(cm.ExtraerCodigo("saldo", "tbl_cuenta", "id_cuenta", txt_Cuenta.Text));
                double importe = System.Convert.ToDouble(txt_Importe.Text);
                LogicaOperacionesExternas loe = new LogicaOperacionesExternas();
                if (saldo <= importe)
                { 
                    verificacionImporte = false;
                }
                else
                {
                    verificacionImporte = true;
                    newSaldo = loe.calculoDeNuevoSaldo(importe.ToString(), saldo.ToString());
                }
            }else if(txt_Importe.Text == "")
            {
                txt_codigo.Text = "0";
            }
            verificacionBotones();
        }

        public void verificacionBotones()
        {
            if (verificacionCodigo == false)
            {
                pcb_NumeroCuenta.Visible = true;
            }
            else
            {
                pcb_NumeroCuenta.Visible = false;
            }

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

            if (verificacionCodigo == false || verificacionImporte == false || txt_codigo.Text == "" || txt_Importe.Text == "")
            {
                btn_Next.Enabled = false;
            }
            else
            {
                btn_Next.Enabled = true;
            }
        }

        private void OperacionExternaSolicitud_Paint(object sender, PaintEventArgs e)
        {
            verificacionBotones();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            txt_codigo.Enabled = false;
            txt_Importe.Enabled = false;
            dtp_Fecha.Enabled = false;
            cbo_Cuenta.Enabled = false;
            cbo_BenExterno.Enabled = false;
            cbo_Agencia.Enabled = false;
            cbo_Empleado.Enabled = false;
            txt_Nota.Enabled = false;
            chb_CodigoTransExt.Enabled = false;
            btn_aceptar.Visible = true;
            btn_Next.Visible = false;
            btn_aceptar.Location = new Point(747, 529);
            btn_Cancelar.Visible = true;
            btn_Clear.Visible = false;
            btn_Cancelar.Location = new Point(652, 529);
            pictureBox2.Visible = true;
            label9.Visible = true;
        }

        public void RegresarAEstadoInicial()
        {
            txt_codigo.Enabled = true;
            txt_Importe.Enabled = true;
            dtp_Fecha.Enabled = true;
            cbo_Cuenta.Enabled = true;
            cbo_BenExterno.Enabled = true;
            cbo_Agencia.Enabled = true;
            cbo_Empleado.Enabled = true;
            txt_Nota.Enabled = true;
            chb_CodigoTransExt.Enabled = true;
            btn_aceptar.Visible = false;
            btn_Next.Visible = true;
            btn_Cancelar.Visible = false;
            btn_Clear.Visible = true;
            pictureBox2.Visible = false;
            label9.Visible = false;
        }

        public void limpiar()
        {
            txt_codigo.Text = "";
            txt_Importe.Text = "";
            cbo_Cuenta.SelectedIndex = 0;
            cbo_BenExterno.SelectedIndex = 0;
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
            try
            {
                ClaseMultiusos cm = new ClaseMultiusos();
                List<string> comandos = new List<string>();
                /*cm.InsertarDatosAplicaciones("tbl_transferencia_externa", txt_codigo.Text + ",'" + dtp_Fecha.Value.ToString("yyyy-MM-dd") + "'," + txt_Importe.Text + ",'" + txt_Nota.Text + "'," + txt_Cuenta.Text + "," + txt_BenExterno.Text + "," + txt_Agencia.Text + "," + txt_Empleado.Text + ", 'Solicitud Enviada' , 1");
                cm.InsertarDatosAplicaciones("tbl_solicitud_compensacion", "0, '" + dtp_Fecha.Value.ToString("yyyy-MM-dd") + "', 'Pendiente'," + txt_codigo.Text);
                cm.InsertarDatosAplicaciones("tbl_movimientos_cuenta", "0, 'Transferencia Externa'," + txt_Importe.Text + ",'" + dtp_Fecha.Value.ToString("yyyy-MM-dd") + "'," + txt_Cuenta.Text + ",1");
                cm.ModificarDatos("tbl_cuenta", "saldo = " + newSaldo, "id_cuenta", txt_Cuenta.Text);*/
                comandos.Add(cm.DevolverSentencia_Insert("tbl_transferencia_externa", txt_codigo.Text + ",'" + dtp_Fecha.Value.ToString("yyyy-MM-dd") + "','" + txt_Importe.Text + "','" + txt_Nota.Text + "'," + txt_Cuenta.Text + "," + txt_BenExterno.Text + "," + txt_Agencia.Text + "," + txt_Empleado.Text + ", 'Solicitud Enviada' , 1"));
                comandos.Add(cm.DevolverSentencia_Insert("tbl_solicitud_compensacion", "0, '" + dtp_Fecha.Value.ToString("yyyy-MM-dd") + "', 'Pendiente'," + txt_codigo.Text));
                comandos.Add(cm.DevolverSentencia_Insert("tbl_movimientos_cuenta", "0,'" + txt_Importe.Text + "','" + dtp_Fecha.Value.ToString("yyyy-MM-dd") + "',1," + txt_Cuenta.Text + ",1,1"));
                comandos.Add(cm.DevolverSentencia_Modificar("tbl_cuenta", "saldo = '" + newSaldo+"'", "id_cuenta", txt_Cuenta.Text));
                //MessageBox.Show(cm.gg());
                cm.EjectuarOperacionExterna(comandos,"Ingreso de Transferencia Externa","81500");
                MessageBox.Show("Transaccion realizada");
                limpiar();
                RegresarAEstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseDeValidaciones cv = new ClaseDeValidaciones();
            cv.SoloNumeros(sender, e);
        }

        private void txt_Nota_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void btn_AddBenExterno_Click(object sender, EventArgs e)
        {
            AddBenExterno form = new AddBenExterno();
            form.ShowDialog();
            ClaseMultiusos cm = new ClaseMultiusos();
            cbo_BenExterno.DataSource = null;
            cbo_BenExterno.Items.Clear();
            cm.cargarDatosACombobox(cbo_BenExterno, "nombres", "tbl_beneficiario_externo");
        }

        private void btn_AddCuenta_Click(object sender, EventArgs e)
        {
            CreacionDeCuentaIngreso form = new CreacionDeCuentaIngreso();
            form.ShowDialog();
            ClaseMultiusos cm = new ClaseMultiusos();
            cbo_Cuenta.DataSource = null;
            cbo_Cuenta.Items.Clear();
            cm.cargarDatosACombobox(cbo_Cuenta, "numero_de_cuenta", "tbl_cuenta");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ruta = @"D:\SEMESTRE IX\INGENIERIADESOFTWARESEMESTREIX\Ayuda\ayuda.chm";
            Help.ShowHelp(this, ruta, "Ayuda.html#");
        }

        private void OperacionExternaSolicitud_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
           // string ruta = Path.GetDirectoryName(Environment.CurrentDirectory) + @"\AyudaOrdenesDeCompra\ayudaOrdenesDC.chm";
            string ruta = @"D:\SEMESTRE IX\INGENIERIADESOFTWARESEMESTREIX\Ayuda\ayuda.chm";
            Help.ShowHelp(this, ruta, "Ayuda.html#OperacionesExternas");
        }
    }
}
