using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL_Opciones;
using CapaDatosOpciones;
using CapaDiseno;


namespace CapaDiseñoOpciones
{
    public partial class DiseñoEleccionDeColores : Form
    {
        Navegador nv = new Navegador();
        CapaLogicaOpciones cd = new CapaLogicaOpciones();
        public DiseñoEleccionDeColores(DataGridView dgv)
        {
            InitializeComponent();
            nv.nombreForm(this);
            nv.dgv_datos(dgv);
            nv.ingresarTabla("tbl_colores");
        }

        private void DiseñoEleccionDeColores_Load(object sender, EventArgs e)
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
            /*try
            {
                Colores cl = cd.obtenerColores();
                textBox1.Text = cl.ID.ToString();
                textBox2.Text = cl.Nombre.ToString();
                textBox3.Text = cl.Fondo.ToString();
                textBox4.Text = cl.BarraDeTitulo.ToString();
                textBox5.Text = cl.BarraDeMenu.ToString();
                textBox6.Text = cl.BarraDeEstado.ToString();
                textBox7.Text = cl.BarraDeTituloAplicaciones.ToString();
                textBox8.Text = cl.FondoAplicaciones.ToString();
                textBox9.Text = cl.FunteDeTexto1.ToString();
                textBox10.Text = cl.FunteDeTexto2.ToString();
                textBox11.Text = cl.FunteDeTexto3.ToString();
                textBox12.Text = cl.utilizado.ToString();
            }catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }*/
        }

        public string getRGB(string hex) {
            string rgb = "";
            byte r, g, b;
            if (hex.Length == 3)
            {
                r = Convert.ToByte(hex[0] + "" + hex[0], 16);
                g = Convert.ToByte(hex[1] + "" + hex[1], 16);
                b = Convert.ToByte(hex[2] + "" + hex[2], 16);
            }
            else if (hex.Length == 6)
            {
                r = Convert.ToByte(hex[0] + "" + hex[1], 16);
                g = Convert.ToByte(hex[2] + "" + hex[3], 16);
                b = Convert.ToByte(hex[4] + "" + hex[5], 16);
            }
            else
            {
                throw new ArgumentException("Hex Color " + hex + " is invalid.");
            }
            rgb = Color.FromArgb(255, r, g, b).ToArgb().ToString();
            return rgb;
        }

        public void FColor(TextBox tx, TextBox tx1, Button b)
        {
            colorDialog1.ShowDialog();
            Color myColor = colorDialog1.Color;
            tx1.Text = myColor.ToArgb().ToString();
        }
        public void FillColor(TextBox tx, TextBox tx1, Button b)
        {
            Color myColor = Color.FromArgb(Convert.ToInt32(tx1.Text));
            b.BackColor = myColor;
            string hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            tx.Text = hex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FColor(txt_hexfondo, txt_nFondo, btn_Fondo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FColor(txt_hexBarraT, txt_nBarraT, btn_BarraTitulo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FColor(txt_hexBarraM, txt_nBarraM, btn_Barramenu);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            txt_Status.Text = "1";
        }

        private void btn_BarraEstado_Click(object sender, EventArgs e)
        {
            FColor(txt_hexBarraE, txt_nBarraE, btn_BarraEstado);
        }

        private void btn_Fuente1_Click(object sender, EventArgs e)
        {
            FColor(txt_hexF1, txt_nF1, btn_Fuente1);
        }

        private void btn_Fuente2_Click(object sender, EventArgs e)
        {
            FColor(txt_hexF2, txt_nF2, btn_Fuente2);
        }

        private void btn_Fuente3_Click(object sender, EventArgs e)
        {
            FColor(txt_hexF3, txt_nF3, btn_Fuente3);
        }

        private void btn_BarraTituloA_Click(object sender, EventArgs e)
        {
            FColor(txt_hexBarraTA, txt_nBarraTA, btn_BarraTituloA);
        }

        private void btn_FondoA_Click(object sender, EventArgs e)
        {
            FColor(txt_hexFondoA, txt_nFondoA, btn_FondoA);
        }

        private void txt_nFondo_TextChanged(object sender, EventArgs e)
        {
            if(txt_nFondo.Text == "")
            {
                txt_nFondo.Text = "-1";
            }
            FillColor(txt_hexfondo, txt_nFondo, btn_Fondo);
        }

        private void txt_nBarraT_TextChanged(object sender, EventArgs e)
        {
            if (txt_nBarraT.Text == "")
            {
                txt_nBarraT.Text = "-1";
            }
            FillColor(txt_hexBarraT, txt_nBarraT, btn_BarraTitulo);
        }

        private void txt_nBarraM_TextChanged(object sender, EventArgs e)
        {
            if (txt_nBarraM.Text == "")
            {
                txt_nBarraM.Text = "-1";
            }
            FillColor(txt_hexBarraM, txt_nBarraM, btn_Barramenu);
        }

        private void txt_nBarraE_TextChanged(object sender, EventArgs e)
        {
            if (txt_nBarraE.Text == "")
            {
                txt_nBarraE.Text = "-1";
            }
            FillColor(txt_hexBarraE, txt_nBarraE, btn_BarraEstado);
        }

        private void txt_nF1_TextChanged(object sender, EventArgs e)
        {
            if (txt_nF1.Text == "")
            {
                txt_nF1.Text = "-1";
            }
            FillColor(txt_hexF1, txt_nF1, btn_Fuente1);
        }

        private void txt_nF2_TextChanged(object sender, EventArgs e)
        {
            if (txt_nF2.Text == "")
            {
                txt_nF2.Text = "-1";
            }
            FillColor(txt_hexF2, txt_nF2, btn_Fuente2);
        }

        private void txt_nF3_TextChanged(object sender, EventArgs e)
        {
            if (txt_nF3.Text == "")
            {
                txt_nF3.Text = "-1";
            }
            FillColor(txt_hexF3, txt_nF3, btn_Fuente3);
        }

        private void txt_nBarraTA_TextChanged(object sender, EventArgs e)
        {
            if (txt_nBarraTA.Text == "")
            {
                txt_nBarraTA.Text = "-1";
            }
            FillColor(txt_hexBarraTA, txt_nBarraTA, btn_BarraTituloA);
        }

        private void txt_nFondoA_TextChanged(object sender, EventArgs e)
        {
            if (txt_nFondoA.Text == "")
            {
                txt_nFondoA.Text = "-1";
            }
            FillColor(txt_hexFondoA, txt_nFondoA, btn_FondoA);
        }
    }
}
