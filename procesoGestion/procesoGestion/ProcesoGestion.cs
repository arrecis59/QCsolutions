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
        private Gestion gestion = new Gestion();
        private Cliente cliente = new Cliente();
        private static DateTime fechaActual = DateTime.Today;

        public frm_proceso_gestion()
        {
            InitializeComponent();

            //Inicializacion
            txt_fecha.Text = fechaActual.ToLongDateString();
            //if(operacion == "MODIFICAR")
        }

        //Nueva Gestion

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            this.cliente = TransaccionCliente.consultarCliente(txt_dpi.Text);
            txt_nomCliente.Text = this.cliente.getNombreCompleto();
            txt_fecNac.Text = this.cliente.fecha_nac.ToShortDateString();
            txt_genero.Text = this.cliente.genero;
            txt_correo.Text = this.cliente.correo;
            txt_telefono.Text = this.cliente.telefono;
            txt_celular.Text = this.cliente.celular;
            txt_nit.Text = this.cliente.nit;
            
        }

    }
}
