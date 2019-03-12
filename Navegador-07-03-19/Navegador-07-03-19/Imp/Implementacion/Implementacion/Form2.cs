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
    public partial class Form2 : Form
    {
        Navegador nv = new Navegador();
        public static DataGridView dg = new DataGridView();


        public Form2(DataGridView dgv)
        {
            InitializeComponent();
            //MessageBox.Show("Form");
            dg = dgv;

            nv.nombreForm(this);
            nv.dgv_datos(dgv);

            nv.ingresarTabla("tbl_aplicacion");


        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = (DataTable)dg.DataSource;                  // Se crea un datatable que contenga los datos del data grid


            Aplicaciones Cr = new Aplicaciones();
            Cr.SetDataSource(Dt);                           // Se le asignan los datos al crystal report.

            VisualizarReporte vsR = new VisualizarReporte();
            vsR.CrVAplicaciones.ReportSource = Cr;
            vsR.ShowDialog();
        }
    }
}
