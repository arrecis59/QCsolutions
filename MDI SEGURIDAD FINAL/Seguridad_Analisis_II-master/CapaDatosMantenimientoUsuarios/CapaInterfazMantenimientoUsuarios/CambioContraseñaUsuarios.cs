using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaMantenimientoUsuarios;
using CapaDatosMantenimientoUsuarios;
using CapaDiseñoOpciones;       // LLamada a la capa de diseño
using CapaDatosOpciones;        // LLamada a capa de datos para importar la clase de colores
using CapaDiseno;               // LLamada a capa del navegador   

namespace CapaInterfazMantenimientoUsuarios
{
    public partial class CambioContraseñaUsuarios : Form
    {
        public string UsuarioActual = "";
        public CambioContraseñaUsuarios(string str_nUsuario)
        {
            InitializeComponent();
            UsuarioActual = str_nUsuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LogicaMantenimientoUsuarios lmu = new LogicaMantenimientoUsuarios();
                lmu.ValidarModificarCambioDeContraseña(txt_Nusuario.Text, txt_NContraseña.Text, txt_Confirm.Text);
                clean();
            }
            catch (Exception ex)
            {

            }
        }

        private void CambioContraseñaUsuarios_Load(object sender, EventArgs e)
        {
            CapaDiseño_Opciones cd = new CapaDiseño_Opciones();
            Colores cl = cd.obtenerColores();
            try
            {
                if (cl.ID.ToString() != "")
                {
                    pnl_Titulo.BackColor = Color.FromArgb(Convert.ToInt32(cl.BarraDeTituloAplicaciones));
                    pnl_Inferior.BackColor = Color.FromArgb(Convert.ToInt32(cl.BarraDeTituloAplicaciones));
                    this.BackColor = Color.FromArgb(Convert.ToInt32(cl.FondoAplicaciones));
                    //Lbl_asignacionPerfiles.ForeColor = Color.FromArgb(Convert.ToInt32(cl.FunteDeTexto4));
                }
            }
            catch (Exception ex) { }
            if (UsuarioActual != "")
            {
                txt_Nusuario.Text = UsuarioActual;
            }else
            {
                MessageBox.Show("No se ha encontrado usuario. ", "ERROR");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_Confirm.PasswordChar == '*')
            {
                txt_Confirm.PasswordChar = '\0';
            }
            else if (txt_Confirm.PasswordChar == '\0')
            {
                txt_Confirm.PasswordChar = '*';
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DatosMantenimientoUsuarios dmu = new DatosMantenimientoUsuarios();
            string[] h;
            h = new string[2];
            h = dmu.cargarDatos1(UsuarioActual);
            txt_NContraseña.Text = h[0];
            txt_Confirm.Text = h[1];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_NContraseña.PasswordChar == '*')
            {
                txt_NContraseña.PasswordChar = '\0';
            }
            else if (txt_NContraseña.PasswordChar == '\0')
            {
                txt_NContraseña.PasswordChar = '*';
            }
        }

        public void clean()
        {
            txt_Confirm.Text = "";
            txt_NContraseña.Text = "";
            txt_Nusuario.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
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
