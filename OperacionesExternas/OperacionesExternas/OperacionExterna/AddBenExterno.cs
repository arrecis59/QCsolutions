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
    public partial class AddBenExterno : Form
    {
        public AddBenExterno()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static bool validacionNC = false;

        private void AddBenExterno_Load(object sender, EventArgs e)
        {
            chb_ID.Checked = true;
            ClaseMultiusos cm = new ClaseMultiusos();
            cm.cargarDatosACombobox(cbo_BancoExterno, "nombre", "tbl_bancos_externos");
            cm.cargarDatosACombobox(cbo_Cliente, "nombre", "tbl_cliente");

        }

        private void cbo_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_cliente", "tbl_cliente", "nombre", cbo_Cliente.Text);
            txt_Cliente.Text = codigo;
        }

        private void cbo_BancoExterno_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_bancos_externos", "tbl_bancos_externos", "nombre", cbo_BancoExterno.Text);
            txt_BancoExterno.Text = codigo;
        }

        private void chb_ID_CheckedChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            if (chb_ID.Checked == true)
            {
                txt_ID.Text = cm.GenerarAutoCodigo("id_beneficiario_externo", "tbl_beneficiario_externo");
            }
            else
            {
                txt_ID.Text = "";
            }
        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            if (txt_ID.Text != "")
            {
                if (cm.ValidarExistenciaDeCodigos("tbl_beneficiario_externo", "id_beneficiario_externo", txt_ID.Text) == false)
                {
                    validacionNC = false;
                }
                else
                {
                    validacionNC = true;
                }
            }
            validacionBotones();
        }


        public void validacionBotones()
        {
            if (validacionNC == false)
            {
                pcb_Id.Visible = true;
            }
            else
            {
                pcb_Id.Visible = false;
            }

            //

            if (validacionNC == false || txt_CuentaDestino.Text == "" || txt_TipoCuentaDestino.Text == "" || txt_Nombre.Text == "" || txt_Apellido1.Text == "" || txt_TipoDoc.Text == "" || txt_NDoc.Text == "" || txt_Telefono.Text == "" || txt_Correo.Text == "" || txt_Cliente.Text == "" || txt_BancoExterno.Text == "" )
            {
                btn_aceptar.Enabled = false;
            }
            else
            {
                btn_aceptar.Enabled = true;
            }
        }


        public void limpiar()
        {
            txt_ID.Text = "";
            txt_CuentaDestino.Text = "";
            txt_TipoCuentaDestino.Text = "";
            txt_Nombre.Text = "";
            txt_Apellido1.Text = "";
            txt_Apellido2.Text = "";
            txt_TipoDoc.Text = "";
            txt_NDoc.Text = "";
            txt_Telefono.Text = "";
            txt_Correo.Text = "";
            cbo_Cliente.SelectedIndex = 0;
            cbo_BancoExterno.SelectedIndex = 0;
            chb_ID.Checked = true;
        }

        public void regresarAEstadoInicial()
        {
            limpiar();
            btn_aceptar.Enabled = true;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseMultiusos cm = new ClaseMultiusos();
                cm.InsertarDatosAplicaciones("tbl_beneficiario_externo", txt_ID.Text + "," + txt_CuentaDestino.Text + ",'" + txt_TipoCuentaDestino.Text + "','" + txt_Nombre.Text + "','" + txt_Apellido1.Text + "','" + txt_Apellido2.Text + "','" + txt_TipoDoc.Text + "'," + txt_NDoc.Text + "," + txt_Telefono.Text + ",'" + txt_Correo.Text + "'," + txt_Cliente.Text + "," + txt_BancoExterno.Text + ",1");
                MessageBox.Show("Datos Ingresados");
                regresarAEstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_CuentaDestino_TextChanged(object sender, EventArgs e)
        {
            validacionBotones();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
