using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatosMantenimientoAplicaciones;
using CapaDiseno;
using CapaDatosOpciones;                // LLamada a la capa de datos para exportar el objeto colores
using CapaDiseñoOpciones;               // LLamada a la capa de diseño para exportar funciones

namespace CapaInterfazMantenimientoAplicaciones
{
    public partial class InterfazMostrarAplicaciones : Form
    {
        Navegador nv = new Navegador();
        DataTable dt;
        public Form frm;
        public InterfazMostrarAplicaciones(Form frm2)
        {
            InitializeComponent();
            frm = frm2;
        }

        private void InterfazMostrarAplicaciones_Load(object sender, EventArgs e)
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
            dt = nv.cargarDatos("tbl_aplicacion");
            Dgv_aplicaciones.DataSource = dt;
            /*DataSet ds;
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            ds = dmm.ConsultarDatosAplicacion();
            Dgv_aplicaciones.DataSource = ds.Tables[0];*/
        }

        private void Dgv_aplicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InterfazIngrearAplicaciones frm3 = new InterfazIngrearAplicaciones(Dgv_aplicaciones);
            frm3.MdiParent = frm;
            frm3.Show();
            Application.DoEvents();
            /*string Id_reference = "";
            InterfazModificarAplicaciones imu = new InterfazModificarAplicaciones();
            if (Dgv_aplicaciones.SelectedCells.Count > 0)
            {
                int selectedrowindex = Dgv_aplicaciones.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Dgv_aplicaciones.Rows[selectedrowindex];
                Id_reference = Convert.ToString(selectedRow.Cells[1].Value);
            }
            imu.DatosAModificarAplicaciones = Id_reference;
            this.Hide();
            imu.Show();*/
        }

        private void Dgv_aplicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
