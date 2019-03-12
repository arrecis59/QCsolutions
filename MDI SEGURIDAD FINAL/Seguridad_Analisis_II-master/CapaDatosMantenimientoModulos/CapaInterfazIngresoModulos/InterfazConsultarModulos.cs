using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CapaDatosMantenimientoModulos;
using CapaDiseñoOpciones;       // LLamada a la capa de diseño
using CapaDatosOpciones;        // LLamada a capa de datos para importar la clase de colores
using CapaDiseno;               // LLamada a capa del navegador   

namespace CapaInterfazIngresoModulos
{
    public partial class Interfaz_Consultar_Modulos : Form
    {
        Navegador nv = new Navegador();
        DataTable dt;
        public Form frm;
        public Interfaz_Consultar_Modulos(Form frm2)
        {
            InitializeComponent();
            frm = frm2;
        }

        private void InterfazConsultarModulos_Load(object sender, EventArgs e)
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
            DataSet ds;
            /*DatosMantenimientoModulos dmm = new DatosMantenimientoModulos();
            ds = dmm.ConsultarDatosModulo();
            dataGridView1.DataSource = ds.Tables[0];*/
            dt = nv.cargarDatos("tbl_modulo");
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InterfazIngresoModulos frm3 = new InterfazIngresoModulos(dataGridView1);
            frm3.MdiParent = frm;
            frm3.Show();
            Application.DoEvents();
            /*string Id_reference = "";
            InterfazModificarModulos imu = new InterfazModificarModulos();
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                Id_reference = Convert.ToString(selectedRow.Cells[1].Value);
            }
            imu.DatosAModificarModulo = Id_reference;
            this.Hide();
            imu.Show();*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
