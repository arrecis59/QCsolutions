using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CapaDiseno;
using DatosConsultaSaldos;


namespace ConsultaSaldos
{
    public partial class ConsultaSaldos : Form
    {

        public ConsultaSaldos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultaSaldos_Load(object sender, EventArgs e)
        {
            DatosConsultaSaldos.CapaDatosConsultaSaldos cds = new CapaDatosConsultaSaldos();

            DataSet ds = cds.LlenarGridWhere("numero_de_cuenta as NUMERO_DE_CUENTA, saldo as SALDO, FK_id_tipo_cuenta as TIPO_CUENTA, FK_id_moneda as MONEDA", "tbl_cuenta", "1", "1");
            dataGridView1.DataSource = ds.Tables[0];
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
