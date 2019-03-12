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
using CapaLogicaMantenimientoModulos;
using CapaDiseñoOpciones;       // LLamada a la capa de diseño
using CapaDatosOpciones;        // LLamada a capa de datos para importar la clase de colores
using CapaDiseno;               // LLamada a capa del navegador   

namespace CapaInterfazIngresoModulos
{
    public partial class InterfazIngresoModulos : Form
    {
        Navegador nv = new Navegador();
        public InterfazIngresoModulos(DataGridView dgv)
        {
            InitializeComponent();
            nv.nombreForm(this);
            nv.dgv_datos(dgv);
            nv.ingresarTabla("tbl_modulo");
        }

        public void clear()
        {
            txt_Codigo.Text = "";
            txt_Nombre.Text = "";
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {


            //Validar solo numeros
            Regex Val = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");
            if (Val.IsMatch(txt_Codigo.Text))
            {
                //Guardar
                LogicaMantenimientoModulos lmm = new LogicaMantenimientoModulos();
                lmm.ValidarInsertarDatosModulos(txt_Codigo.Text, txt_Nombre.Text);
                clear();
            }
            else
            {
                MessageBox.Show("Codigo solo debe llevar numeros", "Error de Sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Codigo.Focus();
            }
            
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txt_status.Text = "1";
        }

        private void InterfazIngresoModulos_Load(object sender, EventArgs e)
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
    }
}
