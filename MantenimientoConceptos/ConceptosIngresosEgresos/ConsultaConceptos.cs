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

namespace ConceptosIngresosEgresos
{
    public partial class ConsultaConceptos : Form
    {
        Navegador navegador = new Navegador();
        DataTable dataTable = new DataTable();
        public ConsultaConceptos(int codUsuario, Form form)
        {
            InitializeComponent();
            navegador.getDatos();
            dataTable = navegador.cargarDatos("tbl_conceptos_flujo_efectivo");
            dgw_Conceptos.DataSource = dataTable;
        }

        private void formData_Load(object sender, EventArgs e)
        {
            
        }
    }
}
