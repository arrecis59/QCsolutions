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

namespace Empleado
{
    public partial class empleadoMantenimiento : Form
    {
        Navegador nv = new Navegador();
        int change = -1; 


        public empleadoMantenimiento(DataGridView dgv)
        {
            InitializeComponent();

            nv.nombreForm(this);
            nv.dgv_datos(dgv);
            nv.ingresarTabla("tbl_empleado");


            DataSet dt = nv.cargarCombobox("tbl_tipo_empleado", "nombre");
            cbm_Tipo_Empleado.DataSource = dt.Tables[0].DefaultView;
            cbm_Tipo_Empleado.ValueMember = "Nombre";


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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

        private void empleadoMantenimiento_Load(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                cbm_Tipo_Empleado.SelectedIndex = Convert.ToInt32(this.textBox10.Text.ToString()) - 1;
            }
            else
            {
                cbm_Tipo_Empleado.SelectedIndex = -1;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            change++;

            if (change > 0)
            {
                textBox10.Text = Convert.ToString(nv.findSelectedItem("id_tipo_empleado", "tbl_tipo_empleado", "nombre", cbm_Tipo_Empleado.Text.ToString()));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SegundoNombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_SegundoApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
