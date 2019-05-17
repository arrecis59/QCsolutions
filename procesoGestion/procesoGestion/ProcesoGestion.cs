using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procesoGestion
{
    public partial class frm_proceso_gestion : Form
    {
        Gestion gestion = new Gestion();
        Cliente cliente = new Cliente();

        public frm_proceso_gestion()
        {
            InitializeComponent();
            //if(operacion == "MODIFICAR")
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            this.cliente = TransaccionCliente.consultaGes(txt_dpi.Text);
            txt_nomCliente.Text = this.cliente.getNombreCompleto();
        }   
    }
}
