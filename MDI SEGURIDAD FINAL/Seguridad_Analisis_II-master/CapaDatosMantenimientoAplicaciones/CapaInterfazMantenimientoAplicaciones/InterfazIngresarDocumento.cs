using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaMantenimientoAplicaciones;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CapaDatosMantenimientoAplicaciones;
using RetornoCadenaDeConexion;
using System.Data.Odbc;
using CapaDiseñoOpciones;       // LLamada a la capa de diseño
using CapaDatosOpciones;        // LLamada a capa de datos para importar la clase de colores
using CapaDiseno;               // LLamada a capa del navegador        

namespace CapaInterfazMantenimientoAplicaciones
{
    public partial class InterfazIngresarDocumento : Form
    {
        Navegador nv = new Navegador();
        public InterfazIngresarDocumento(DataGridView dgv)
        {
            InitializeComponent();
            nv.nombreForm(this);
            nv.dgv_datos(dgv);
            nv.ingresarTabla("tbl_doc_asociado");
        }

        private void InterfazIngresarDocumento_Load(object sender, EventArgs e)
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
            cargarDatosaTxt_nombre_Modulo();
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            Txt_codigoAppi.Text = dmm.ExtraerCodigoDeAplicacion(Cbo_nombre_appi.Text);
        }
        public void cargarDatosaTxt_nombre_Modulo()
        {
            CadenaDeConexion cdc = new CadenaDeConexion();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT api_descripcion FROM tbl_aplicacion";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                Cbo_nombre_appi.Items.Add(Reader["api_descripcion"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
                Cbo_nombre_appi.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            //Validar solo numeros
            Regex Val = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");
            if (Val.IsMatch(Txt_CodigoDoc.Text))
            {
                //Guardar
                LogicaMantenimientoAplicaciones lma = new LogicaMantenimientoAplicaciones();
                lma.ValidarInsertarDatosDocumento(Txt_CodigoDoc.Text, Txt_NombreDoc.Text, Txt_Ruta.Text, Txt_codigoAppi.Text);
            }
            else
            {
                MessageBox.Show("Codigo solo debe llevar numeros", "Error de Sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_CodigoDoc.Focus();
            }
           }

        private void Cbo_nombre_modulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            Txt_codigoAppi.Text = dmm.ExtraerCodigoDeAplicacion(Cbo_nombre_appi.Text);
        }
        
        public void clean()
        {
            Txt_codigoAppi.Text = "";
            Txt_CodigoDoc.Text = "";
            Txt_Ruta.Text = "";
            Cbo_nombre_appi.SelectedIndex = 0;
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            clean();
        }

        public string agregardiagonal(string cadena)
        {
            return cadena.Replace("\\", "\\\\");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Txt_Ruta.Text = agregardiagonal(openFileDialog1.FileName);
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Txt_codigoAppi_TextChanged(object sender, EventArgs e)
        {
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            Txt_codigoAppi.Text = dmm.ExtraerCodigoDeAplicacion(Cbo_nombre_appi.Text);
        }
    }
}
