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

namespace OperacionesExternas.OperacionExterna
{
    public partial class ConsultaDeOperaciones : Form
    {
        public ConsultaDeOperaciones()
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

        private void ConsultaDeOperaciones_Load(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            cbo_TipoBusqueda.SelectedIndex = 0;
            
            DataSet ds = cm.LlenarGridWStatus("id_transferencia_externa as Codigo, fecha as Fecha, importe as Importe, nota as Nota, FK_id_cuenta as Cuenta, FK_id_beneficiario_externo as BeneficiarioExterno, FK_id_agencia as Agencia, FK_id_empleado as Empleado, Estado as Estado", "tbl_transferencia_externa");
            dtg_Cuentas.DataSource = ds.Tables[0];
        }

        private void txt_Busqueda_TextChanged(object sender, EventArgs e)
        {
            string datosSentencia = "id_transferencia_externa as Codigo, fecha as Fecha, importe as Importe, nota as Nota, FK_id_cuenta as Cuenta, FK_id_beneficiario_externo as BeneficiarioExterno, FK_id_agencia as Agencia, FK_id_empleado as Empleado, Estado as Estado";
            string tabla = "tbl_transferencia_externa";
            ClaseMultiusos cm = new ClaseMultiusos();
            if (txt_Busqueda.Text == "")
            {
                DataSet ds = cm.LlenarGridWStatus(datosSentencia, tabla);
                dtg_Cuentas.DataSource = ds.Tables[0];
            }
            else if (cbo_TipoBusqueda.Text == "Codigo")
            {
                DataSet ds = cm.LlenarGridWhereLike(datosSentencia, tabla, "id_transferencia_externa", txt_Busqueda.Text);
                dtg_Cuentas.DataSource = ds.Tables[0];
            }
            else if (cbo_TipoBusqueda.Text == "Fecha")
            {
                DataSet ds = cm.LlenarGridWhereLike(datosSentencia, tabla, "fecha", txt_Busqueda.Text);
                dtg_Cuentas.DataSource = ds.Tables[0];
            }
            else if (cbo_TipoBusqueda.Text == "Cuenta")
            {
                DataSet ds = cm.LlenarGridWhereLike(datosSentencia, tabla, "FK_id_cuenta", txt_Busqueda.Text);
                dtg_Cuentas.DataSource = ds.Tables[0];
            }
            else if (cbo_TipoBusqueda.Text == "Beneficiario Externo")
            {
                DataSet ds = cm.LlenarGridWhereLike(datosSentencia, tabla, "FK_id_beneficiario_externo", txt_Busqueda.Text);
                dtg_Cuentas.DataSource = ds.Tables[0];
            }
            else if (cbo_TipoBusqueda.Text == "Agencia")
            {
                DataSet ds = cm.LlenarGridWhereLike(datosSentencia, tabla, "FK_id_agencia", txt_Busqueda.Text);
                dtg_Cuentas.DataSource = ds.Tables[0];
            }
            else if (cbo_TipoBusqueda.Text == "Empleado")
            {
                DataSet ds = cm.LlenarGridWhereLike(datosSentencia, tabla, "FK_id_empleado", txt_Busqueda.Text);
                dtg_Cuentas.DataSource = ds.Tables[0];
            }
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            cbo_TipoBusqueda.SelectedIndex = 0;

            DataSet ds = cm.LlenarGridWStatus("id_transferencia_externa as Codigo, fecha as Fecha, importe as Importe, nota as Nota, FK_id_cuenta as Cuenta, FK_id_beneficiario_externo as BeneficiarioExterno, FK_id_agencia as Agencia, FK_id_empleado as Empleado, Estado as Estado", "tbl_transferencia_externa");
            dtg_Cuentas.DataSource = ds.Tables[0];
            txt_Busqueda.Text = "";
        }
    }
}
