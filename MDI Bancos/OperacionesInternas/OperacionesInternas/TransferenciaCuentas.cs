using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaOperacionesInternas;

namespace OperacionesInternas
{
    public partial class TransferenciaCuentas : Form
    {
        LogicaOperacionesInternas lg = new LogicaOperacionesInternas();
        

        private void cargarEmpleados()
        {
            cbo_Empleado.DataSource = lg.getEmpleados().Tables["emp"].DefaultView;
            cbo_Empleado.DisplayMember = "empleados";
        }


        public TransferenciaCuentas()
        {
            InitializeComponent();

            //CARGAS COMBOBOX
            cargarEmpleados();
        }
    }
}
