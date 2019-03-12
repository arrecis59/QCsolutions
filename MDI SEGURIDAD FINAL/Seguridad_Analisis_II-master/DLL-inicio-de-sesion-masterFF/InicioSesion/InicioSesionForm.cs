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
using CapaDatosOpciones;
using CapaDiseñoOpciones;

namespace InicioSesion
{
    public partial class pnl_Menu : Form
    {
        graphicLayer bitcara = new graphicLayer();
        public pnl_Menu()
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

        private void InicioSesionForm_Load(object sender, EventArgs e)
        {
            CapaDiseño_Opciones cd = new CapaDiseño_Opciones();
            Colores cl = cd.obtenerColores();
            try
            {
                if (cl.ID.ToString() != "")
                {
                    pnl_Inicio.BackColor = Color.FromArgb(Convert.ToInt32(cl.BarraDeTitulo));
                    this.BackColor = Color.FromArgb(Convert.ToInt32(cl.FondoAplicaciones));
                    Lbl_loginPass.ForeColor = Color.FromArgb(Convert.ToInt32(cl.FunteDeTexto1));
                    Lbl_loginUser.ForeColor = Color.FromArgb(Convert.ToInt32(cl.FunteDeTexto1));
                    //Lbl_asignacionPerfiles.ForeColor = Color.FromArgb(Convert.ToInt32(cl.FunteDeTexto4));
                }
            }
            catch (Exception ex) { }
        }
    }
}
