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
    public partial class AddCliente : Form
    {
        public AddCliente()
        {
            InitializeComponent();
        }

        public static bool validacionNC = false;

        private void AddCliente_Load(object sender, EventArgs e)
        {
            chb_ID.Checked = true;
            cbo_Genero.SelectedIndex = 0;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chb_ID_CheckedChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            if (chb_ID.Checked == true)
            {
                txt_idCliente.Text = cm.GenerarAutoCodigo("id_cliente", "tbl_cliente");
            }
            else
            {
                txt_idCliente.Text = "";
            }
        }

        private void txt_idCliente_TextChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            if (txt_idCliente.Text != "")
            {
                if (cm.ValidarExistenciaDeCodigos("tbl_cliente", "id_cliente", txt_idCliente.Text) == false)
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

            if (validacionNC == false ||txt_DPI.Text == ""|| txt_idCliente.Text==""|| txt_correo.Text == ""|| txt_nombreCl.Text == "" || txt_Apellido1.Text == "" || txt_Apellido2.Text == "" || txt_Telefono.Text == "" || txt_Celular.Text == "" || dtp_FecNac.Text == "" || cbo_Genero.Text == "" || txt_NIT.Text == "")
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
            txt_idCliente.Text = "";
            txt_nombreCl.Text = "";
            txt_Apellido1.Text = "";
            txt_Apellido2.Text = "";
            txt_Telefono.Text = "";
            txt_Celular.Text = "";
            txt_correo.Text = "";
            txt_DPI.Text = "";
            txt_NIT.Text = "";
            cbo_Genero.SelectedIndex = 0;
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
                cm.InsertarDatosAplicaciones("tbl_cliente", txt_idCliente.Text + "," + txt_DPI.Text + ",'" + txt_nombreCl.Text + "','" + txt_Apellido1.Text + "','" + txt_Apellido2.Text + "'," + txt_Telefono.Text + "," + txt_Celular.Text + ",'" + txt_correo.Text + "','" + dtp_FecNac.Value.ToString("yyyy-MM-dd") + "','" + cbo_Genero.Text + "','" + txt_NIT.Text + "',1");
                MessageBox.Show("Datos Ingresados");
                regresarAEstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txt_idCliente_TextChanged_1(object sender, EventArgs e)
        {
            validacionBotones();
        }
    }
}
