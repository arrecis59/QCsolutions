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
using CapaLogicaMantenimientoAplicaciones;
using CapaDatosOpciones;                // LLamada a la capa de datos para exportar el objeto colores
using CapaDiseñoOpciones;               // LLamada a la capa de diseño para exportar funciones
using CapaDiseno;                       // LLamada a la capa del navegador


namespace CapaInterfazMantenimientoAplicaciones
{
    public partial class InterfazMostrarDocumentosRelacionados : Form
    {
        Navegador nv = new Navegador();
        DataTable dt;
        public Form frm;
        public InterfazMostrarDocumentosRelacionados(Form frm2)
        {
            InitializeComponent();
            frm = frm2;
        }

        string Id_reference = "";

        private void InterfazMostrarDocumentosRelacionados_Load(object sender, EventArgs e)
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
            dt = nv.cargarDatos("tbl_doc_asociado");
            Dgv_aplicaciones.DataSource = dt;
            /*DataSet ds;
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            ds = dmm.ConsultarDatosDocumentos();
            Dgv_aplicaciones.DataSource = ds.Tables[0];*/
        }

        private void Dgv_aplicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_aplicaciones.SelectedCells.Count > 0)
            {
                int selectedrowindex = Dgv_aplicaciones.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Dgv_aplicaciones.Rows[selectedrowindex];
                Id_reference = Convert.ToString(selectedRow.Cells[0].Value);
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            LogicaMantenimientoAplicaciones lma = new LogicaMantenimientoAplicaciones();
            lma.ValidarBorrarDatosDocumento(Id_reference);
            DataSet ds;
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            ds = dmm.ConsultarDatosDocumentos();
            Dgv_aplicaciones.DataSource = ds.Tables[0];
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dgv_aplicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dgv_aplicaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InterfazIngresarDocumento frm3 = new InterfazIngresarDocumento(Dgv_aplicaciones);
            frm3.MdiParent = frm;
            frm3.Show();
            Application.DoEvents();
        }
    }
}
