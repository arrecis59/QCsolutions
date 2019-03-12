using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL__Reporteador;
using System.Data.Odbc;

namespace pruebaDLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DLL__Reporteador.Administrador adm = new Administrador();
            adm.AbrirAdministrador(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DLL__Reporteador.Visualizador vs = new Visualizador();
                vs.AbrirReporte(1);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = (DataTable)dataGridView1.DataSource;                  // Se crea un datatable que contenga los datos del data grid
            dataGridView2.DataSource = Dt;

            DLL__Reporteador.Visualizador vp = new Visualizador();
            Prueba pp = new Prueba();

            vp.generarReporte(Dt, pp);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*dataGridView1.Columns.Add("PK_Api_codigo", "codigo");
            dataGridView1.Columns.Add("api_descripcion", "name");
            dataGridView1.Columns.Add("FK_Codigo_modulo", "mod");
            dataGridView1.Columns.Add("status", "sta");

            dataGridView1.Rows.Add("1", "Ramos", "1", "1");
            dataGridView1.Rows.Add("2", "Ramoas", "2", "1");
            dataGridView1.Rows.Add("3", "Ramosb", "1", "1");
            dataGridView1.Rows.Add("4", "Ramosc", "2", "1");*/


            DataSet ds = new DataSet();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM tbl_aplicacion";
                            OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            m_datos.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            /*MySqlConnection conexion = new MySqlConnection("Server=localhost; User Id=root; Password='tu password'; Database=nombre_de_la_BD");

            ------------------------------------------------- ----

            Luego en el evento Load del Form carga los datos al DataGridView:

            MySqlDataAdapter da = new MySqlDataAdapter("select * from CLIENTE", conexion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];*/

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = (DataTable)dataGridView1.DataSource;                  // Se crea un datatable que contenga los datos del data grid
            dataGridView2.DataSource = Dt;
        }
    }
}
