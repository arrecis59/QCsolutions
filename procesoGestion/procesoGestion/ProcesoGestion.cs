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
        private Empleado empleado = new Empleado();
        private DateTime fechaActual = DateTime.Today;
        private string accion = null;
        //ComboBox cmb_motivo_gestion = ComboBoxItem.llenarCmb(TransaccionMotivoGestion.getItems());

        public frm_proceso_gestion()
        {
            InitializeComponent();
            this.accion = "NUEVO";
            txt_fecha.Text = fechaActual.ToLongDateString();
            initFormNuevo();
        }

        public frm_proceso_gestion(int idGestion)
        {
            InitializeComponent();
            this.accion = "MODIFICAR";
            this.gestion = TransaccionGestion.consultarGestion(idGestion);
            initFormSeguimiento();

        }

        //Busca cliente por DPI.
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


        private void frm_proceso_gestion_Load(object sender, EventArgs e)
        {
            
        }

        private void llenarPrioridad(ComboBox cmb)
        {
            cmb.Items.Add("5");
            cmb.Items.Add("4");
            cmb.Items.Add("3");
            cmb.Items.Add("2");
            cmb.Items.Add("1");
        }

        //Crea o modifica gestion.
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.accion == "NUEVO")
            {
                //si esta marcado el auto genera el id a gestion.
                if (ckb_idGestion.Checked)
                    this.gestion.idGestion = TransaccionGestion.getMaxId();

                reunirDatosGestion();
                if (TransaccionGestion.insertarGestion(this.gestion))
                    MessageBox.Show("Creado exitosamente.");
            }if (this.accion == "MODIFICAR")
            {
                reunirDatosSeguimiento();
                if (TransaccionGestion.seguimientoGestion(this.gestion))
                    MessageBox.Show("Creado exitosamente.");
            }
        }

        private void btn_cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        
        //Inicializa el form para una nueva gestion.
        public void initFormNuevo()
        {
            TransaccionMotivoGestion.cargaComboBox(cmb_motivo);
            TransaccionEstadoGestion.cargaComboBox(cmb_estado);
            llenarPrioridad(cmb_prioridad);
            this.empleado = TransaccionEmpleado.consultarEmpleado(10);

            txt_idGestion.Enabled = true;
            txt_fecha.Enabled = false;
            txt_dpi.Enabled = true;
            txt_nomCliente.Enabled = false;
            txt_fecNac.Enabled = false;
            txt_genero.Enabled = false;
            txt_correo.Enabled = false;
            txt_telefono.Enabled = false;
            txt_celular.Enabled = false;
            txt_nit.Enabled = false;
            cmb_motivo.Enabled = true;
            cmb_prioridad.Enabled = true;
            cmb_estado.Enabled = true;
            txt_descripcion.Enabled = true;
            btnBuscarCliente.Enabled = true;
            btnBuscarCliente.Show();
            ckb_idGestion.Enabled = true;
            
            cmb_estado.SelectedIndex = 0;
            cmb_motivo.SelectedIndex = 0;
            cmb_prioridad.SelectedIndex = 0;

        }

        //Inicializa el form con una gestion.
        private void initFormSeguimiento()
        {
            TransaccionMotivoGestion.cargaComboBox(cmb_motivo);
            TransaccionEstadoGestion.cargaComboBox(cmb_estado);
            llenarPrioridad(cmb_prioridad);
            this.empleado = TransaccionEmpleado.consultarEmpleado(10);

            txt_idGestion.Enabled = false;
            txt_fecha.Enabled = false;
            txt_dpi.Enabled = false;
            txt_nomCliente.Enabled = false;
            txt_fecNac.Enabled = false;
            txt_genero.Enabled = false;
            txt_correo.Enabled = false;
            txt_telefono.Enabled = false;
            txt_celular.Enabled = false;
            txt_nit.Enabled = false;
            cmb_motivo.Enabled = false;
            cmb_prioridad.Enabled = false;
            cmb_estado.Enabled = true;
            txt_descripcion.Enabled = true;
            btnBuscarCliente.Enabled = false;
            btnBuscarCliente.Hide();
            ckb_idGestion.Enabled = false;
            if (this.gestion.estado.idEstadoGestion == 2)
                btn_guardar.Enabled = false;
            else
                btn_guardar.Enabled = true;

            txt_idGestion.Text = this.gestion.idGestion.ToString();
            txt_fecha.Text = this.gestion.fecha_gestion.ToLongDateString();
            txt_dpi.Text = this.gestion.cliente.DPI.ToString();
            txt_nomCliente.Text = this.gestion.cliente.getNombreCompleto();
            txt_fecNac.Text = this.gestion.cliente.fecha_nac.ToShortDateString();
            txt_genero.Text = this.gestion.cliente.genero;
            txt_correo.Text = this.gestion.cliente.correo;
            txt_telefono.Text = this.gestion.cliente.telefono;
            txt_celular.Text = this.gestion.cliente.celular;
            txt_nit.Text = this.gestion.cliente.nit;
            cmb_motivo.Text = this.gestion.motivo.idMotivoGestion.ToString();
            cmb_prioridad.Text = this.gestion.prioridad.ToString();
            cmb_estado.Text = this.gestion.estado.idEstadoGestion.ToString();
            txt_descripcion.Text = this.gestion.descripcion;
        }

        //De los campos del form crea el objeto Gestion para insert.
        private void reunirDatosGestion()
        {
            this.gestion.idGestion = Convert.ToInt32(txt_idGestion.Text);
            this.gestion.fecha_gestion = this.fechaActual;
            this.gestion.fecha_gestion = this.fechaActual;
            this.gestion.descripcion = txt_descripcion.Text;
            this.gestion.empl_servicio = this.empleado;
            this.gestion.empl_solucion = this.empleado;
            this.gestion.cliente = this.cliente;
            this.gestion.motivo = TransaccionMotivoGestion.consultarMotivo(Convert.ToInt32(cmb_motivo.Text));
            this.gestion.estado = TransaccionEstadoGestion.consultarEstado(Convert.ToInt32(cmb_estado.Text));
            this.gestion.prioridad = Convert.ToInt32(cmb_prioridad.Text);
        }

        //De los campos del form actualiza el objeto Gestion para update.
        private void reunirDatosSeguimiento()
        {
            this.gestion.fecha_solucion = this.fechaActual;
            this.gestion.descripcion = txt_descripcion.Text;
            this.gestion.empl_solucion = this.empleado;
            this.gestion.estado = TransaccionEstadoGestion.consultarEstado(Convert.ToInt32(cmb_estado.Text));
        }
    }
}
