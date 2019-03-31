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

namespace OperacionesExternas.BeneficiarioExterno
{
    public partial class IngresoBeneficiarioExterno : Form
    {
        Navegador nv = new Navegador();

        int change = -1;
        int changea = -1;
        int changeb = -1;

        public IngresoBeneficiarioExterno(DataGridView dgv)
        {
            InitializeComponent();

            nv.nombreForm(this);
            nv.dgv_datos(dgv);

            nv.ingresarTabla("tbl_beneficiario_externo");


            DataSet dt = nv.cargarCombobox("tbl_tipo_cuenta", "descripcion");      // Cargar comobo box
            cbo_TipoCuenta.DataSource = dt.Tables[0].DefaultView;
            cbo_TipoCuenta.ValueMember = "descripcion";
            //
            DataSet dta = nv.cargarCombobox("tbl_cliente", "nombre");      // Cargar comobo box
            cbo_Cliente.DataSource = dta.Tables[0].DefaultView;
            cbo_Cliente.ValueMember = "Nombre";
            //
            DataSet dtb = nv.cargarCombobox("tbl_bancos_externos", "nombre");      // Cargar comobo box
            cbo_BancoExterno.DataSource = dtb.Tables[0].DefaultView;
            cbo_BancoExterno.ValueMember = "nombre";
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void txt_Apellido2_TextChanged(object sender, EventArgs e)
        {
            if(txt_Apellido2.Text == "")
            {
                txt_Apellido2.Text = "**";
            }
        }

        private void IngresoBeneficiarioExterno_Load(object sender, EventArgs e)
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
            if (txt_Cliente.Text != "")
            {
                cbo_Cliente.SelectedIndex = Convert.ToInt32(this.txt_Cliente.Text.ToString()) - 1;
            }
            else
            {
                cbo_Cliente.SelectedIndex = -1;
            }
            //
            if (txt_BancoExterno.Text != "")
            {
                cbo_BancoExterno.SelectedIndex = Convert.ToInt32(this.txt_BancoExterno.Text.ToString()) - 1;
            }
            else
            {
                cbo_BancoExterno.SelectedIndex = -1;
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

        private void cbo_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            changea++;

            if (changea > 0)
            {
                txt_Cliente.Text = Convert.ToString(nv.findSelectedItem("id_cliente", "tbl_cliente", "nombre", cbo_Cliente.Text.ToString()));
            }
        }

        private void cbo_BancoExterno_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            changeb++;

            if (changeb > 0)
            {
                txt_BancoExterno.Text = Convert.ToString(nv.findSelectedItem("id_bancos_externos", "tbl_bancos_externos", "nombre", cbo_BancoExterno.Text.ToString()));
            }
        }
    }
}
