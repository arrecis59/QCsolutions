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
    public partial class dataEmpleado : Form
    {
        DataTable dtEmpleado = new DataTable();
        Navegador nv = new Navegador();

        public dataEmpleado(int userCode)
        {
            InitializeComponent();
            nv.getDatos(userCode, 40000);

            dtEmpleado = nv.cargarDatos("tbl_empleado");
            dataGridView1.DataSource = dtEmpleado;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Form1(dataGridView1).Show();
            
        }

        private void dataEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
             Dt = dataGridView1.DataSource as DataTable;                    // Se crea el datatable con los valores del datagrid


             Aplicaciones Cr = new Aplicaciones();
             Cr.SetDataSource(Dt);                                           // Se le asignan los datos al crystal report.

             VisualizarReporte vsR = new VisualizarReporte();       
             vsR.CrVAplicaciones.ReportSource = Cr;                         // Se envia el reporte para que se abra
             vsR.ShowDialog();
        }
    }
}
