using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatosMantenimientoUsuarios;
using CapaInterfazMantenimientoUsuarios;
using System.IO;
using CapaDatosOpciones;                // LLamada a la capa de datos para exportar el objeto colores
using CapaDiseñoOpciones;               // LLamada a la capa de diseño para exportar funciones
using CapaDiseno;                       // LLamada a la capa del navegador

namespace CapaInterfazMantenimientoUsuarios
{
    public partial class Interfaz_Mostrar_Usuarios : Form
    {
        Navegador nv = new Navegador();
        DataTable dt;
        public Form frm;
        public Interfaz_Mostrar_Usuarios(Form frm2)
        {
            InitializeComponent();
            frm = frm2;
        }

        private void InterfazMostrarUsuarios_Load(object sender, EventArgs e)
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
            /*DataSet ds;
            DatosMantenimientoUsuarios dmu = new DatosMantenimientoUsuarios();
            ds = dmu.ConsultarDatosDeUsuarios1();
            dataGridView1.DataSource = ds.Tables[0];*/
            dt = nv.cargarDatos("tbl_usuario");
            dataGridView1.DataSource = dt;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           /* if (checkBox1.Checked)
            {
                DataSet ds;
                DatosMantenimientoUsuarios dmu = new DatosMantenimientoUsuarios();
                ds = dmu.ConsultarDatosDeUsuarios();
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                DataSet ds;
                DatosMantenimientoUsuarios dmu = new DatosMantenimientoUsuarios();
                ds = dmu.ConsultarDatosDeUsuarios1();
                dataGridView1.DataSource = ds.Tables[0];
            }*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Interfaz_Mostrar_Usuarios_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string rutaCompleta = "" + Path.GetDirectoryName(Environment.CurrentDirectory) + @"\ayudabitacora\ayuda.chm";
            Help.ShowHelp(this, rutaCompleta, "AyudaBitacora.html#ayudabitacora");
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InterfazCrearUsuarios frm3 = new InterfazCrearUsuarios(dataGridView1);
            frm3.MdiParent = frm;
            frm3.Show();
            Application.DoEvents();
        }
    }
}
