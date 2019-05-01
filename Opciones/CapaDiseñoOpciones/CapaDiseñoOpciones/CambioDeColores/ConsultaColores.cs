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
using CapaDatosOpciones;

namespace CapaDiseñoOpciones.CambioDeColores
{
    public partial class ConsultaColores : Form
    {
        Navegador nv = new Navegador();
        DataTable dt;
        public Form frmMDI2;

        public ConsultaColores(int intUsuarioCodigo, Form frmMDI)
        {
            InitializeComponent();
            Navegador nv2 = new Navegador();
            nv2.getDatos(intUsuarioCodigo, 81540);
            frmMDI2 = frmMDI;


            dt = nv2.cargarDatos("tbl_colores");
            dt_Colores.DataSource = dt;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ConsultaColores_Load(object sender, EventArgs e)
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
            dt = nv.cargarDatos("tbl_colores");
            dt_Colores.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DiseñoEleccionDeColores frm3 = new DiseñoEleccionDeColores(dt_Colores);
            frm3.MdiParent = frmMDI2;
            frm3.Show();
            Application.DoEvents();
        }
    }
}
