using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;

namespace MantenimientoCuentas
{
    public partial class IngresoDeCuentas : Form
    {
        Navegador nv = new Navegador();

        int change = -1;
        int changea = -1;
        int changeb = -1;
        int changec = -1;
        int changed = -1;

        public IngresoDeCuentas(DataGridView dgv)
        {
            InitializeComponent();

            nv.nombreForm(this);
            nv.dgv_datos(dgv);

            nv.ingresarTabla("tbl_cuenta");


            DataSet dt = nv.cargarCombobox("tbl_tipo_cuenta", "descripcion");      // Cargar comobo box
            cbo_TipoCuenta.DataSource = dt.Tables[0].DefaultView;
            cbo_TipoCuenta.ValueMember = "descripcion";
            //
            DataSet dta = nv.cargarCombobox("tbl_empleado", "nombre");      // Cargar comobo box
            cbo_Empleado.DataSource = dta.Tables[0].DefaultView;
            cbo_Empleado.ValueMember = "Nombre";
            //
            DataSet dtb = nv.cargarCombobox("tbl_agencia", "nombre");      // Cargar comobo box
            cbo_Agencia.DataSource = dtb.Tables[0].DefaultView;
            cbo_Agencia.ValueMember = "nombre";
            //
            DataSet dtc = nv.cargarCombobox("tbl_moneda", "nombre");      // Cargar comobo box
            cbo_Moneda.DataSource = dtc.Tables[0].DefaultView;
            cbo_Moneda.ValueMember = "nombre";
            //
            DataSet dtd = nv.cargarCombobox("tbl_organizacion_clientes", "nombre_organizacion");      // Cargar comobo box
            cbo_Organizacion.DataSource = dtd.Tables[0].DefaultView;
            cbo_Organizacion.ValueMember = "nombre_organizacion";
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IngresoDeCuentas_Load(object sender, EventArgs e)
        {
            //
            if (txt_TipoCuenta.Text != "")
            {
                cbo_TipoCuenta.SelectedIndex = Convert.ToInt32(this.txt_TipoCuenta.Text.ToString()) - 1;
            }
            else
            {
                cbo_TipoCuenta.SelectedIndex = -1;
            }
            //
            if (txt_Empleado.Text != "")
            {
                cbo_Empleado.SelectedIndex = Convert.ToInt32(this.txt_Empleado.Text.ToString()) - 1;
            }
            else
            {
                cbo_Empleado.SelectedIndex = -1;
            }
            //
            if (txt_Agencia.Text != "")
            {
                cbo_Agencia.SelectedIndex = Convert.ToInt32(this.txt_Agencia.Text.ToString()) - 1;
            }
            else
            {
                cbo_Agencia.SelectedIndex = -1;
            }
            //
            if (txt_Moneda.Text != "")
            {
                cbo_Moneda.SelectedIndex = Convert.ToInt32(this.txt_Moneda.Text.ToString()) - 1;
            }
            else
            {
                cbo_Moneda.SelectedIndex = -1;
            }
            //
            if (txt_Organizacion.Text != "")
            {
                cbo_Organizacion.SelectedIndex = Convert.ToInt32(this.txt_Organizacion.Text.ToString()) - 1;
            }
            else
            {
                cbo_Organizacion.SelectedIndex = -1;
            }
        }

        private void cbo_TipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            change++;

            if (change > 0)
            {
                txt_TipoCuenta.Text = Convert.ToString(nv.findSelectedItem("id_tipo_cuenta", "tbl_tipo_cuenta", "descripcion", cbo_TipoCuenta.Text.ToString()));
            }
        }

        private void cbo_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            changea++;

            if (changea > 0)
            {
                txt_Empleado.Text = Convert.ToString(nv.findSelectedItem("id_empleado", "tbl_empleado", "nombre", cbo_Empleado.Text.ToString()));
            }

        }

        private void cbo_Agencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeb++;

            if (changeb > 0)
            {
                txt_Agencia.Text = Convert.ToString(nv.findSelectedItem("id_agencia", "tbl_agencia", "nombre", cbo_Agencia.Text.ToString()));
            }
        }

        private void cbo_Moneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            changec++;

            if (changec > 0)
            {
                txt_Moneda.Text = Convert.ToString(nv.findSelectedItem("id_moneda", "tbl_moneda", "nombre", cbo_Moneda.Text.ToString()));
            }
        }

        private void cbo_Organizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            changed++;

            if (changed > 0)
            {
                txt_Organizacion.Text = Convert.ToString(nv.findSelectedItem("id_organizacion", "tbl_organizacion_clientes", "nombre_organizacion", cbo_Organizacion.Text.ToString()));
            }
        }
    }
}
