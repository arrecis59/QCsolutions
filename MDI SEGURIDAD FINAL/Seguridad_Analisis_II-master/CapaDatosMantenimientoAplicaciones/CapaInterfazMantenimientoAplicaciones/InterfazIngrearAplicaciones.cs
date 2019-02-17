using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CapaDatosMantenimientoAplicaciones;
using CapaLogicaMantenimientoAplicaciones;
using RetornoCadenaDeConexion;
using System.Data.Odbc;

namespace CapaInterfazMantenimientoAplicaciones
{
    public partial class InterfazIngrearAplicaciones : Form
    {
        public InterfazIngrearAplicaciones()
        {
            InitializeComponent();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            //Validar solo numeros
            Regex Val = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");
            if (Val.IsMatch(Txt_CodigoApp.Text))
            {
                //Guardar
                LogicaMantenimientoAplicaciones lma = new LogicaMantenimientoAplicaciones();
                lma.ValidarInsertarDatosAplicaiones(Txt_CodigoApp.Text, Txt_NombreApp.Text);
                clean();
            }
            else
            {
                MessageBox.Show("Codigo solo debe llevar numeros", "Error de Sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_CodigoApp.Focus();
            }

        }

        private void InterfazIngrearAplicaciones_Load(object sender, EventArgs e)
        {
        }

        private void Cbo_nombre_modulo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Txt_CodigoApp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_NombreApp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_nombre_Modulo_TextChanged(object sender, EventArgs e)
        {

        }

        public void clean()
        {
            Txt_CodigoApp.Text = "";
            Txt_NombreApp.Text = "";
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
