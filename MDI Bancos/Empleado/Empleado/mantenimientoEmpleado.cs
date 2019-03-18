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
    public partial class mantenimientoEmpleado : Form
    {

        Navegador nv = new Navegador();
        int changeA = -1;

        public mantenimientoEmpleado(DataGridView dgv)
        {
            InitializeComponent();

            nv.nombreForm(this);
            nv.dgv_datos(dgv);

            nv.ingresarTabla("tbl_empleado");


            //TIPO EMPLEADO
            DataSet dt = nv.cargarCombobox("tbl_tipo_empleado", "nombre");
            comboBox2.DataSource = dt.Tables[0].DefaultView;
            comboBox2.ValueMember = "Nombre";


        }

        private void mantenimientoEmpleado_Load(object sender, EventArgs e)
        {

            /*dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yy-MM-dd";*/

            if (textBox7.Text != "")
            { comboBox1.SelectedIndex = Convert.ToInt32(this.textBox7.Text.ToString()) - 1; }
            else
            { comboBox2.SelectedIndex = -1; }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeA++;

            if (changeA > 0)
            {
                textBox7.Text = Convert.ToString(nv.findSelectedItem("id_tipo_empleado", "tbl_tipo_empleado", "nombre", comboBox2.Text.ToString()));
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
    }
}
