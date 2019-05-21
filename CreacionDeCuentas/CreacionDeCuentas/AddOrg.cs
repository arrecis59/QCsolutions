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
    public partial class AddOrg : Form
    {
        public AddOrg()
        {
            InitializeComponent();
        }

        public static bool validacionNC = false;

        private void AddOrg_Load(object sender, EventArgs e)
        {
            chb_IDOrg.Checked = true;
        }

        private void chb_IDOrg_CheckedChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            if (chb_IDOrg.Checked == true)
            {
                txt_idOrg.Text = cm.GenerarAutoCodigo("id_organizacion", "tbl_organizacion_clientes");
            }
            else
            {
                txt_idOrg.Text = "";
            }
        }

        private void txt_idOrg_TextChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            if (txt_idOrg.Text != "")
            {
                if (cm.ValidarExistenciaDeCodigos("tbl_organizacion_clientes", "id_organizacion", txt_idOrg.Text) == false)
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
                pcb_IdCuenta.Visible = true;
            }
            else
            {
                pcb_IdCuenta.Visible = false;
            }

            //

            if (validacionNC == false || txt_idOrg.Text == "" || txt_nombreOrg.Text == "")
            {
                btn_aceptar.Enabled = false;
            }
            else
            {
                btn_aceptar.Enabled = true;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            txt_idOrg.Text = "";
            txt_nombreOrg.Text = "";
            chb_IDOrg.Checked = false;
        }

        public void regresarAEstadoInicial()
        {
            txt_idOrg.Text = "";
            txt_nombreOrg.Text = "";
            chb_IDOrg.Checked = true;
            btn_aceptar.Enabled = true;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseMultiusos cm = new ClaseMultiusos();
                cm.InsertarDatosAplicaciones("tbl_organizacion_clientes", txt_idOrg.Text + ",'" + txt_nombreOrg.Text + "'");
                MessageBox.Show("Datos Ingresados");
                regresarAEstadoInicial();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nombreOrg_TextChanged(object sender, EventArgs e)
        {
            validacionBotones();
        }
    }
}
