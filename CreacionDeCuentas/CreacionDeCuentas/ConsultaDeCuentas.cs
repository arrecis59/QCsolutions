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

namespace CreacionDeCuentas
{
    public partial class ConsultaDeCuentas : Form
    {
        public ConsultaDeCuentas()
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

        private void ConsultaDeCuentas_Load(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos(); 
            cbo_TipoBusqueda.SelectedIndex = 0;
            DataSet ds = cm.LlenarGridWStatus("id_cuenta as Codigo, numero_de_cuenta as NumeroDeCuenta, fecha_creacion as FechaDeCreacion, saldo as Saldo, FK_id_tipo_cuenta as TipoCuenta, FK_id_agencia as Agencia, FK_id_moneda as Moneda", "tbl_cuenta");
            dtg_Cuentas.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Busqueda_TextChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            if (txt_Busqueda.Text == "")
            {
                DataSet ds = cm.LlenarGridWStatus("id_cuenta as Codigo, numero_de_cuenta as NumeroDeCuenta, fecha_creacion as FechaDeCreacion, saldo as Saldo, FK_id_tipo_cuenta as TipoCuenta, FK_id_agencia as Agencia, FK_id_moneda as Moneda", "tbl_cuenta");
                dtg_Cuentas.DataSource = ds.Tables[0];
            }else if (cbo_TipoBusqueda.Text == "Numero de Cuenta")
            {
                DataSet ds = cm.LlenarGridWhereLike("id_cuenta as Codigo, numero_de_cuenta as NumeroDeCuenta, fecha_creacion as FechaDeCreacion, saldo as Saldo, FK_id_tipo_cuenta as TipoCuenta, FK_id_agencia as Agencia, FK_id_moneda as Moneda", "tbl_cuenta","numero_de_cuenta",txt_Busqueda.Text);
                dtg_Cuentas.DataSource = ds.Tables[0];
            }
            else if (cbo_TipoBusqueda.Text == "Codigo de Cuenta")
            {
                DataSet ds = cm.LlenarGridWhereLike("id_cuenta as Codigo, numero_de_cuenta as NumeroDeCuenta, fecha_creacion as FechaDeCreacion, saldo as Saldo, FK_id_tipo_cuenta as TipoCuenta, FK_id_agencia as Agencia, FK_id_moneda as Moneda", "tbl_cuenta", "id_cuenta", txt_Busqueda.Text);
                dtg_Cuentas.DataSource = ds.Tables[0];
            }
            else if (cbo_TipoBusqueda.Text == "Fecha de Creacion")
            {
                DataSet ds = cm.LlenarGridWhereLike("id_cuenta as Codigo, numero_de_cuenta as NumeroDeCuenta, fecha_creacion as FechaDeCreacion, saldo as Saldo, FK_id_tipo_cuenta as TipoCuenta, FK_id_agencia as Agencia, FK_id_moneda as Moneda", "tbl_cuenta", "fecha_creacion", txt_Busqueda.Text);
                dtg_Cuentas.DataSource = ds.Tables[0];
            }
            else if (cbo_TipoBusqueda.Text == "Agencia")
            {
                DataSet ds = cm.LlenarGridWhereLike("id_cuenta as Codigo, numero_de_cuenta as NumeroDeCuenta, fecha_creacion as FechaDeCreacion, saldo as Saldo, FK_id_tipo_cuenta as TipoCuenta, FK_id_agencia as Agencia, FK_id_moneda as Moneda", "tbl_cuenta", "FK_id_agencia", txt_Busqueda.Text);
                dtg_Cuentas.DataSource = ds.Tables[0];
            }
            else if (cbo_TipoBusqueda.Text == "Organizacion")
            {
                DataSet ds = cm.LlenarGridWhere("DISTINCT id_cuenta as Codigo, numero_de_cuenta as NumeroDeCuenta, fecha_creacion as FechaDeCreacion, saldo as Saldo, FK_id_tipo_cuenta as TipoCuenta, FK_id_agencia as Agencia, FK_id_moneda as Moneda", "tbl_cuenta, tbl_cliente_has_tbl_cuenta, tbl_cliente_has_tbl_organizacion_clientes", "id_cuenta", "tbl_cliente_has_tbl_cuenta.FK_id_Cuenta AND tbl_cliente_has_tbl_cuenta.FK_id_Cliente = tbl_cliente_has_tbl_organizacion_clientes.FK_id_Cliente AND FK_id_Organizacion = " + txt_Busqueda.Text);
                dtg_Cuentas.DataSource = ds.Tables[0];
            }
        }

        private void dtg_Cuentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtg_Cuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string dato = "";
            if (e.RowIndex >= 0)
            {
                dato = dtg_Cuentas.Rows[e.RowIndex].Cells[0].Value.ToString();
                ModificarCuenta md = new ModificarCuenta(dato);
                md.ShowDialog();
            }
        }

        private void ConsultaDeCuentas_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            cbo_TipoBusqueda.SelectedIndex = 0;
            DataSet ds = cm.LlenarGridWStatus("id_cuenta as Codigo, numero_de_cuenta as NumeroDeCuenta, fecha_creacion as FechaDeCreacion, saldo as Saldo, FK_id_tipo_cuenta as TipoCuenta, FK_id_agencia as Agencia, FK_id_moneda as Moneda", "tbl_cuenta");
            dtg_Cuentas.DataSource = ds.Tables[0];
        }
    }
}
