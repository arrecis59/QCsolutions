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
using CapaDatosMantenimientoAplicaciones;
using CapaLogicaMantenimientoAplicaciones;
using RetornoCadenaDeConexion;
using System.Data.Odbc;
using CapaDiseno;               // LLamada a capa del navegador   
using CapaDatosOpciones;                // LLamada a la capa de datos para exportar el objeto colores
using CapaDiseñoOpciones;               // LLamada a la capa de diseño para exportar funciones

namespace CapaInterfazMantenimientoAplicaciones
{
    public partial class InterfazIngrearAplicaciones : Form
    {
        Navegador nv = new Navegador();
        public InterfazIngrearAplicaciones(DataGridView dgv)
        {
            InitializeComponent();
            nv.nombreForm(this);
            nv.dgv_datos(dgv);
            nv.ingresarTabla("tbl_aplicacion");
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            //Validar solo numeros
            Regex Val = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");
            if (Val.IsMatch(Txt_CodigoApp.Text))
            {
                //Guardar
                LogicaMantenimientoAplicaciones lma = new LogicaMantenimientoAplicaciones();
                lma.ValidarInsertarDatosAplicaiones(Txt_CodigoApp.Text, Txt_NombreApp.Text, Txt_nombre_Modulo.Text);
            }
            else
            {
                MessageBox.Show("Codigo solo debe llevar numeros", "Error de Sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_CodigoApp.Focus();
            }

        }

        private void InterfazIngrearAplicaciones_Load(object sender, EventArgs e)
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
            Txt_nombre_Modulo.Text = dmm.ExtraerCodigoDeModulo(Cbo_nombre_modulo.Text);
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
                            cmd.CommandText = "SELECT modulo_nombre FROM tbl_modulo";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                Cbo_nombre_modulo.Items.Add(Reader["modulo_nombre"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
                Cbo_nombre_modulo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void Cbo_nombre_modulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            Txt_nombre_Modulo.Text = dmm.ExtraerCodigoDeModulo(Cbo_nombre_modulo.Text);
        }

        private void Txt_CodigoApp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_NombreApp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_nombre_Modulo_TextChanged(object sender, EventArgs e)
        {
            if(Txt_nombre_Modulo.Text == "")
            {
                DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
                Txt_nombre_Modulo.Text = dmm.ExtraerCodigoDeModulo(Cbo_nombre_modulo.Text);
            }
        }

        public void clean()
        {
            Txt_CodigoApp.Text = "";
            Txt_NombreApp.Text = "";
            Cbo_nombre_modulo.SelectedIndex = 0;
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
