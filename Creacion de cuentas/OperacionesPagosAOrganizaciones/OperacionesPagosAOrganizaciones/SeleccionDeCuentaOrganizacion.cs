using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiUsos;
using CapaLogicaPagoAOrganizaciones;

namespace OperacionesPagosAOrganizaciones
{
    public partial class SeleccionDeCuentaOrganizacion : Form
    {
        public SeleccionDeCuentaOrganizacion()
        {
            InitializeComponent();
        }

        public void cargarCBO()
        {
            if (txt_org.Text != "")
            {
                ClaseMultiusos cm = new ClaseMultiusos();
                //cm.cargarDatosACombobox(cbo_idCuenta, "FK_id_Cuenta", "tbl_cliente_has_tbl_cuenta where FK_id_Cliente in (select FK_id_Cliente FROM  tbl_cliente_has_tbl_organizacion_clientes where FK_id_Organizacion = " + txt_org.Text + " having count(FK_id_Cliente) > 1);");
                DataSet ds = cm.LlenarGridWhere("DISTINCT FK_id_Cuenta", "tbl_cliente_has_tbl_cuenta where FK_id_Cliente in (select FK_id_Cliente FROM  tbl_cliente_has_tbl_organizacion_clientes", "FK_id_Organizacion", txt_org.Text + " having count(FK_id_Cliente) > 1);");
                //dtg_Cuentas.DataSource = ds.Tables[0];
                cbo_idCuenta.DataSource = ds.Tables[0].DefaultView;
                cbo_idCuenta.DisplayMember = "FK_id_Cuenta";
                //cbo_idCuenta.DataSource = ds.Tables[0];
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeleccionDeCuentaOrganizacion_Load(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            cm.cargarDatosACombobox(cbo_org, "nombre_organizacion", "tbl_organizacion_clientes");
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_organizacion", "tbl_organizacion_clientes", "nombre_organizacion", cbo_org.Text);
            txt_org.Text = codigo;
            cargarCBO();
        }

        private void cbo_org_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_organizacion", "tbl_organizacion_clientes", "nombre_organizacion", cbo_org.Text);
            txt_org.Text = codigo;

            //----------------------------- Vaciado de textbox al no encontrar cuentas relacionadas con la organizacion

            if (cbo_idCuenta.Text == "")
            {
                txt_numero.Text = "";
                txt_tipo.Text = "";
                txt_moneda.Text = "";
                btn_aceptar.Enabled = false;
            }
        }

        private void txt_org_TextChanged(object sender, EventArgs e)
        {
            cargarCBO();
            ClaseMultiusos cm = new ClaseMultiusos();
            DataSet ds = cm.LlenarGridWhere("id_cliente as codigo, DPI as DPI, nombre as Nombre, apellido_1 as Apellido, telefono as Telefono, celular as Celular, correo as Correo, fecha_nacimiento as FecNac, nit as NIT", "tbl_cliente, tbl_cliente_has_tbl_organizacion_clientes", "id_cliente", "FK_id_cliente AND FK_id_Organizacion =" + txt_org.Text + "");
            dtg_org.DataSource = ds.Tables[0];
        }

        private void cbo_idCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_idCuenta.Text != "" && cbo_idCuenta.Text != "System.Data.DataRowView")
            {
                string[] datos = new string[5];
                LogicaPagoAOrganizaciones lgp = new LogicaPagoAOrganizaciones();
                datos = lgp.cargarTxt_1(cbo_idCuenta.Text);
                txt_numero.Text = datos[1];
                txt_tipo.Text = datos[2];
                txt_moneda.Text = datos[3];
                btn_aceptar.Enabled = true;
            }
            else if(cbo_idCuenta.Text == "")
            {
                txt_numero.Text = "";
                txt_tipo.Text = "";
                txt_moneda.Text = "";
                btn_aceptar.Enabled = false;
            }
        }

        private void cbo_idCuenta_TextChanged(object sender, EventArgs e)
        {
            if (cbo_idCuenta.Text == "")
            {
                txt_numero.Text = "";
                txt_tipo.Text = "";
                txt_moneda.Text = "";
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            PagoAOrganizaciones pg = new PagoAOrganizaciones();
            if (cbo_idCuenta.Text != "" && cbo_idCuenta.Text != "System.Data.DataRowView")
            {
                pg.llenarNCuenta(cbo_idCuenta.Text,cbo_org.Text);
                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
