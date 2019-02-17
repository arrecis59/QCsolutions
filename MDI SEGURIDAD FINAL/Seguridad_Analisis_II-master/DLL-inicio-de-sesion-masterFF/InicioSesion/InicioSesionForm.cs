using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIT;
using CapaLogicaInicioSesion;

namespace InicioSesion
{
    public partial class InicioSesionForm : Form
    {
        graphicLayer bitcara = new graphicLayer();
        public InicioSesionForm()
        {
            InitializeComponent();            
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            string username = Txt_loginUser.Text;
            string password = Txt_loginPass.Text;
            Logica capaLogica = new Logica();

            if (username == "" || password == "")
            {
                MessageBox.Show("Los campos son obligatorios");

            }


            if (capaLogica.login(username, password))
            {
                this.Close();
                //MessageBox.Show("Usuario o contraseña correcta");
                Usuario user = new Usuario();
                String st = "Inicio de seión de usuario: " + user.obtenerUsuario();
                bitcara.Accion(st, "Inicio sesion");                    
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void InicioSesionForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string startupPath = Environment.CurrentDirectory;
            Help.ShowHelp(this, startupPath+ "/ayuda_inicio_sesion/Ayuda_seguridad.chm", "ayuda.html#ayuda");
        }

        private void Btn_loginAyuda_Click(object sender, EventArgs e)
        {
            string startupPath = Environment.CurrentDirectory;
            Help.ShowHelp(this, startupPath + "/ayuda_inicio_sesion/Ayuda_seguridad.chm", "ayuda.html#ayuda");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void obtenerP(int usu, int app)
        {
            Logica l = new Logica();
            l.obtenerPermisos(usu, app);
        }
    }
}
