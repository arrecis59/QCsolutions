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
using BITACORA;
using CapaLogicaMantenimientoUsuarios;
using System.IO;
using CapaDiseñoOpciones;       // LLamada a la capa de diseño
using CapaDatosOpciones;        // LLamada a capa de datos para importar la clase de colores
using CapaDiseno;               // LLamada a capa del navegador            

namespace CapaInterfazMantenimientoUsuarios
{
    public partial class InterfazCrearUsuarios : Form
    {
        Navegador nv = new Navegador();
        public InterfazCrearUsuarios(DataGridView dgv)
        {
            InitializeComponent();
            nv.nombreForm(this);
            nv.dgv_datos(dgv);
            nv.ingresarTabla("tbl_usuario");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Txt_contra.PasswordChar == '*')
            {
                Txt_contra.PasswordChar = '\0';
            }
            else if (Txt_contra.PasswordChar == '\0')
            {
                Txt_contra.PasswordChar = '*';
            }
        }

        public void clean()
        {
            Txt_Nombre.Text = "";
            Txt_contra.Text = "";
            //txt_confirmar.Text = "";
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            //Validar caracteres
            
            Regex reg = new Regex(@"(?=.*\d)(?=.*[a-zA-Z]).*$");
            if (reg.IsMatch(Txt_Nombre.Text))
            {
                /*if (Txt_contra.Text != txt_confirmar.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error de Sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                { 
                    //Guardad
                    LogicaMantenimientoUsuarios lmu = new LogicaMantenimientoUsuarios();
                    lmu.ValidarInsertarDatosDeUsuarios(Txt_Nombre.Text, Txt_contra.Text);
                    clean();
                    //Fin guardar
                }*/
            }
            else
            {
                MessageBox.Show("El nombre de usuario debe ser alfanumerico ", "Error de Sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Nombre.Focus();
            }

           

        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_contra_TextChanged(object sender, EventArgs e)
        {

        }

        private void InterfazCrearUsuarios_Load(object sender, EventArgs e)
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InterfazCrearUsuarios_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string rutaCompleta = "" + Path.GetDirectoryName(Environment.CurrentDirectory) + @"\ayudabitacora\ayuda.chm";
            Help.ShowHelp(this,rutaCompleta, "AyudaBitacora.html#ayudabitacora");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (txt_confirmar.PasswordChar == '*')
            {
                txt_confirmar.PasswordChar = '\0';
            }
            else if (txt_confirmar.PasswordChar == '\0')
            {
                txt_confirmar.PasswordChar = '*';
            }*/
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //txt_Status.Text = "1";
        }

        private void txt_confirmar_TextChanged(object sender, EventArgs e)
        {
           /* if(Txt_contra.Text == txt_confirmar.Text)
            {
                Txt_contra.Tag = 3;
            }
            else
            {
                Txt_contra.Tag = 0;
            }*/
        }
    }
}
