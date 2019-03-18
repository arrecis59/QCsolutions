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

namespace Implementacion
{
    public partial class Form1 : Form
    {
        Navegador nv = new Navegador();
        int change = -1;
        
   

        public Form1( DataGridView dgv)
        {
            InitializeComponent();
            nv.nombreForm(this);
            nv.dgv_datos(dgv);

            nv.ingresarTabla("tbl_empleado");
    
            

           
            DataSet dt = nv.cargarCombobox("tbl_tipo_empleado", "nombre");
            comboBox1.DataSource = dt.Tables[0].DefaultView;
            comboBox1.ValueMember = "Nombre";

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if(textBox10.Text != "")
            {  
                comboBox1.SelectedIndex = Convert.ToInt32(this.textBox10.Text.ToString()) - 1;
            }
            else
            {
                comboBox1.SelectedIndex = -1;
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void navegado0r1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            change++;

           if (change > 0)
            {
                textBox10.Text = Convert.ToString( nv.findSelectedItem("id_tipo_empleado", "tbl_tipo_empleado", "nombre", comboBox1.Text.ToString()) );
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
