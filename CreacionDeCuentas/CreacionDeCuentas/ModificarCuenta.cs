using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaCreacionDeCuentas;
using MultiUsos;

namespace CreacionDeCuentas
{
    public partial class ModificarCuenta : Form
    {
        public ModificarCuenta(string codigo)
        {
            InitializeComponent();
            chb_Orgnizacion.Checked = true;
            ClaseMultiusos cm = new ClaseMultiusos();
            cm.cargarDatosACombobox(cbo_Moneda, "nombre", "tbl_moneda");
            cm.cargarDatosACombobox(cbo_TipoCuenta, "nombre", "tbl_tipo_cuenta");
            cm.cargarDatosACombobox(cbo_Empleado, "nombre", "tbl_empleado");
            cm.cargarDatosACombobox(cbo_Agencia, "nombre", "tbl_agencia");
            cm.cargarDatosACombobox(cbo_Organizacion, "nombre_organizacion", "tbl_organizacion_clientes");
            cm.cargarDatosACombobox(cbo_codCliente, "nombre", "tbl_cliente  ");
            //
            txt_CodigoACambiar.Text = codigo;
            //
        }

        public bool validacionNC = true;
        public bool validacionIDC = true;

        public static string cdnumerocuenta = "";
        public static string cdidcuenta = "";
        public int banderaTipoInsertCuenta = 0;

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ModificarCuenta_Load(object sender, EventArgs e)
        {
            /*chb_IDCuenta.Checked = true;
            chb_NumeroDeCuenta.Checked = true;*/
        }

        private void cbo_Moneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_moneda", "tbl_moneda", "nombre", cbo_Moneda.Text);
            txt_Moneda.Text = codigo;
        }

        private void cbo_TipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_tipo_cuenta", "tbl_tipo_cuenta", "nombre", cbo_TipoCuenta.Text);
            txt_TipoCuenta.Text = codigo;
        }

        private void cbo_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_empleado", "tbl_empleado", "nombre", cbo_Empleado.Text);
            txt_Empleado.Text = codigo;
        }

        private void cbo_Agencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_agencia", "tbl_agencia", "nombre", cbo_Agencia.Text);
            txt_Agencia.Text = codigo;
        }

        private void cbo_Organizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_organizacion", "tbl_organizacion_clientes", "nombre_organizacion", cbo_Organizacion.Text);
            txt_Organizacion.Text = codigo;
        }

        private void txt_Organizacion_TextChanged(object sender, EventArgs e)
        {
            /*ClaseMultiusos cm = new ClaseMultiusos();
            DataSet ds = cm.LlenarGridWhere("nombre as Nombre, apellido_1 as Apellido, telefono as Telefono, celular as Celular, correo as Correo, fecha_nacimiento as FecNac, nit as NIT", "tbl_cliente", "tbl_organizacion_clientes_id_organizacion", txt_Organizacion.Text);
            dtg_Organizacion.DataSource = ds.Tables[0];

            /////
            ///
           // ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("nombre_organizacion", "tbl_organizacion_clientes", "id_organizacion", txt_Organizacion.Text);
            cbo_Organizacion.Text = codigo;*/
        }

        private void chb_NumeroDeCuenta_CheckedChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            if (chb_NumeroDeCuenta.Checked == true)
            {
                txtNumeroCuenta.Text = cm.GenerarAutoCodigo("numero_de_cuenta", "tbl_cuenta");
            }
            else
            {
                txtNumeroCuenta.Text = "";
            }
        }

        private void chb_IDCuenta_CheckedChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            if (chb_IDCuenta.Checked == true)
            {
                txtIdCuenta.Text = cm.GenerarAutoCodigo("id_cuenta", "tbl_cuenta");
            }
            else
            {
                txtIdCuenta.Text = "";
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            bool validacion = true;
            if (validacion == true)
            {
                txtNumeroCuenta.Enabled = false;
                chb_NumeroDeCuenta.Enabled = false;
                txtIdCuenta.Enabled = false;
                chb_IDCuenta.Enabled = false;
                DtpFechaCreacion.Enabled = false;
                cbo_Moneda.Enabled = false;
                cbo_TipoCuenta.Enabled = false;
                cbo_Empleado.Enabled = false;
                cbo_Agencia.Enabled = false;
                cbo_Organizacion.Enabled = false;
                cbo_codCliente.Enabled = false;
                btn_aceptar.Visible = true;
                btn_Next.Visible = false;
                btn_aceptar.Location = new Point(753, 566);
                btn_Cancelar.Visible = true;
                btn_Clear.Visible = false;
                btn_Cancelar.Location = new Point(626, 566);
                btn_eliminar.Visible = false;
                pictureBox1.Visible = true;
                label1.Visible = true;
            }
            else
            {
                btn_eliminar.Visible = true;
                btn_Next.Visible = true;
                btn_aceptar.Visible = false;
                btn_Next.Location = new Point(753, 566);
                btn_Clear.Visible = true;
                btn_Cancelar.Visible = false;
                btn_Clear.Location = new Point(626, 566);
            }
        }

        public void regresarAEstadoInicial()
        {
            txtNumeroCuenta.Enabled = true;
            chb_NumeroDeCuenta.Enabled = true;
            txtIdCuenta.Enabled = true;
            chb_IDCuenta.Enabled = true;
            DtpFechaCreacion.Enabled = true;
            cbo_Moneda.Enabled = true;
            cbo_TipoCuenta.Enabled = true;
            cbo_Empleado.Enabled = true;
            cbo_Agencia.Enabled = true;
            cbo_Organizacion.Enabled = true;
            cbo_codCliente.Enabled = true;
            btn_Next.Visible = true;
            btn_aceptar.Visible = false;
            btn_Next.Location = new Point(753, 566);
            btn_Clear.Visible = true;
            btn_Cancelar.Visible = false;
            btn_Clear.Location = new Point(626, 566);
            btn_eliminar.Visible = true;
            pictureBox1.Visible = false;
            label1.Visible = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            regresarAEstadoInicial();
        }

        private void txtNumeroCuenta_TextChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            if (txtNumeroCuenta.Text != "")
            {
                if (cm.ValidarExistenciaDeCodigos("tbl_cuenta", "numero_de_cuenta", txtNumeroCuenta.Text) == false && txtNumeroCuenta.Text != cdnumerocuenta)
                { 
                    validacionNC = false;
                }
                else
                {
                    validacionNC = true;
                }
            }
        }

        private void txtIdCuenta_TextChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            if (txtIdCuenta.Text != "")
            {
                if (cm.ValidarExistenciaDeCodigos("tbl_cuenta", "id_cuenta", txtIdCuenta.Text) == false && txtIdCuenta.Text != cdidcuenta)
                {
                    validacionIDC = false;
                }
                else
                {
                    validacionIDC = true;
                }
            }
        }

        private void ModificarCuenta_Paint(object sender, PaintEventArgs e)
        {
            if (validacionNC == false)
            {
                pcb_NumeroCuenta.Visible = true;
            }
            else
            {
                pcb_NumeroCuenta.Visible = false;
            }

            //
            if (validacionIDC == false)
            {
                pcb_IdCuenta.Visible = true;
            }
            else
            {
                pcb_IdCuenta.Visible = false;
            }

            //

            if (validacionIDC == false || validacionNC == false || txtNumeroCuenta.Text == "" || txtIdCuenta.Text == "")
            {
                btn_Next.Enabled = false;
            }
            else
            {
                btn_Next.Enabled = true;
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            try
            {
                cm.EliminarDatos("tbl_cliente_has_tbl_cuenta", "FK_id_Cuenta", txt_CodigoACambiar.Text);
                cm.ModificarDatos("tbl_cuenta","id_cuenta=" + txtIdCuenta.Text + ", numero_de_cuenta=" + txtNumeroCuenta.Text + ", fecha_creacion='" + DtpFechaCreacion.Value.ToString("yyyy-MM-dd") + "', FK_id_tipo_cuenta=" + txt_TipoCuenta.Text + ", FK_id_empleado=" + txt_Empleado.Text + ", FK_id_agencia=" + txt_Agencia.Text + ", FK_id_moneda=" + txt_Moneda.Text , "id_cuenta", txt_CodigoACambiar.Text);
                if (banderaTipoInsertCuenta == 0)
                {
                    foreach (DataGridViewRow row in dtg_Organizacion.Rows)
                    {
                        cm.InsertarDatosAplicaciones("tbl_cliente_has_tbl_cuenta", (Convert.ToString(row.Cells[0].Value)) + "," + txtIdCuenta.Text);
                    }
                }
                else if (banderaTipoInsertCuenta == 1)
                {
                    cm.InsertarDatosAplicaciones("tbl_cliente_has_tbl_cuenta", txt_CodCliente.Text + "," + txtIdCuenta.Text);
                }
                limpiar();
                regresarAEstadoInicial();
                MessageBox.Show("Datos Modificados Exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void limpiar()
        {
            txtNumeroCuenta.Text = "";
            txtIdCuenta.Text = "";
            cbo_Agencia.SelectedIndex = 0;
            cbo_Empleado.SelectedIndex = 0;
            cbo_TipoCuenta.SelectedIndex = 0;
            cbo_Moneda.SelectedIndex = 0;
            cbo_Organizacion.SelectedIndex = 0;
            chb_IDCuenta.Checked = false;
            chb_NumeroDeCuenta.Checked = false;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtNumeroCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseDeValidaciones cv = new ClaseDeValidaciones();
            cv.SoloNumeros(sender, e);
        }

        private void txtIdCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseDeValidaciones cv = new ClaseDeValidaciones();
            cv.SoloNumeros(sender, e);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            try
            {
                cm.ModificarDatos("tbl_cuenta", "status = 0 ", "id_cuenta", txt_CodigoACambiar.Text);
                limpiar();
                regresarAEstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_CodigoACambiar_TextChanged(object sender, EventArgs e)
        {
            string[] datos = new string[9];
            ClaseCapaLogicaCreacionDeCuentas cl = new ClaseCapaLogicaCreacionDeCuentas();
            datos = cl.retornoDatosCuentas(txt_CodigoACambiar.Text);

            txtIdCuenta.Text = datos[0];
            cdidcuenta = datos[0];
            txtNumeroCuenta.Text = datos[1];
            cdnumerocuenta = datos[1];
            DtpFechaCreacion.Value = DateTime.Parse(datos[2]);
            txt_TipoCuenta.Text = datos[4];
            txt_Empleado.Text = datos[5];
            txt_Agencia.Text = datos[6];
            txt_Moneda.Text = datos[7];
            //txt_Organizacion.Text = datos[8];
            ClaseMultiusos cm = new ClaseMultiusos();
            if (txtNumeroCuenta.Text != "")
            {
                if (cm.ValidarExistenciaDeCodigos("tbl_cuenta", "numero_de_cuenta", txtNumeroCuenta.Text) == false && txtNumeroCuenta.Text != cdnumerocuenta)
                {
                    validacionNC = false;
                }
                else
                {
                    validacionNC = true;
                }
            }
            if (txtIdCuenta.Text != "")
            {
                if (cm.ValidarExistenciaDeCodigos("tbl_cuenta", "id_cuenta", txtIdCuenta.Text) == false && txtIdCuenta.Text != cdidcuenta)
                {
                    validacionIDC = false;
                }
                else
                {
                    validacionIDC = true;
                }
            }
        }

        private void txt_Moneda_TextChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("nombre", "tbl_empleado", "id_empleado", txt_Moneda.Text);
            cbo_Moneda.Text = codigo;
        }

        private void txt_TipoCuenta_TextChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("nombre", "tbl_tipo_cuenta", "id_tipo_cuenta", txt_TipoCuenta.Text);
            cbo_TipoCuenta.Text = codigo;
        }

        private void txt_Empleado_TextChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("nombre", "tbl_empleado", "id_empleado", txt_Empleado.Text);
            cbo_Empleado.Text = codigo;
        }

        private void txt_Agencia_TextChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("nombre", "tbl_agencia", "id_agencia", txt_Agencia.Text);
            cbo_Agencia.Text = codigo;
        }

        private void chb_Orgnizacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Orgnizacion.Checked == true)
            {
                chb_ClientU.Checked = false;
                pnl_org.Visible = true;
                banderaTipoInsertCuenta = 0;
            }
            else
            {
                chb_ClientU.Checked = true;
                pnl_org.Visible = false;
                banderaTipoInsertCuenta = 1;
            }
        }

        private void chb_ClientU_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ClientU.Checked == true)
            {
                chb_Orgnizacion.Checked = false;
                pnl_CliUni.Visible = true;
                banderaTipoInsertCuenta = 1;
            }
            else
            {
                chb_Orgnizacion.Checked = true;
                pnl_CliUni.Visible = false;
                banderaTipoInsertCuenta = 0;
            }
        }

        private void cbo_codCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_cliente", "tbl_cliente", "nombre", cbo_codCliente.Text);
            txt_CodCliente.Text = codigo;
        }

        private void txt_CodCliente_TextChanged(object sender, EventArgs e)
        {
            string[] datos;
            datos = new string[10];
            ClaseCapaLogicaCreacionDeCuentas cpl = new ClaseCapaLogicaCreacionDeCuentas();
            datos = cpl.retornoDatosCliente(txt_CodCliente.Text);
            txt_nombreC.Text = datos[2];
            txt_apeC.Text = datos[3];
        }

        private void txt_Organizacion_TextChanged_1(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            DataSet ds = cm.LlenarGridWhere("id_cliente as codigo, DPI as DPI, nombre as Nombre, apellido_1 as Apellido, telefono as Telefono, celular as Celular, correo as Correo, fecha_nacimiento as FecNac, nit as NIT", "tbl_cliente, tbl_cliente_has_tbl_organizacion_clientes", "id_cliente", "FK_id_cliente AND FK_id_Organizacion =" + txt_Organizacion.Text + "");
            dtg_Organizacion.DataSource = ds.Tables[0];


            string codigo = "";
            codigo = cm.ExtraerCodigo("nombre_organizacion", "tbl_organizacion_clientes", "id_organizacion", txt_Organizacion.Text);
            cbo_Organizacion.Text = codigo;
        }
    }
}