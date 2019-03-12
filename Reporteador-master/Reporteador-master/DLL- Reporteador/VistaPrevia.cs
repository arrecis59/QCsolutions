using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL__Reporteador
{
    public partial class VistaPrevia : Form
    {
        public VistaPrevia(DataTable dg)
        {
            InitializeComponent();
            dataGridView1.DataSource = dg;
        }

        private void VistaPrevia_Load(object sender, EventArgs e)
        {

        }
    }
}
