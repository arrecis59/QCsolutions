using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InicioSesion;
using DiseñoTipoTransferencia;
using MantenimientoAgencias;
using CapaDiseñoOpciones;
//using TipoEmpleado;
//using Empleado;
/*using MantenimientoTipoDeCuenta;*/
using MantenimientoTipoDeCambio;
using Manttenimiento_Moneda;
using CapaDatosOpciones;
using CapaDiseñoOpciones.CambioDeColores;
/*using MantenimientoBancosExternos;*/
using Seguridad2;







namespace MDI_Bancos
{
    public partial class BankMDI : Form
    {
        public BankMDI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CapaDiseño_Opciones cd = new CapaDiseño_Opciones();
            Colores cl = cd.obtenerColores();
            if (cl.ID.ToString() != "")
            {
                pct_Icono.BackColor = Color.FromArgb(Convert.ToInt32(cl.BarraDeTitulo));
                pnl_barraTitulo.BackColor = Color.FromArgb(Convert.ToInt32(cl.BarraDeTitulo));
                menuStrip1.BackColor = Color.FromArgb(Convert.ToInt32(cl.BarraDeMenu));
                pnl_Fecha.BackColor = Color.FromArgb(Convert.ToInt32(cl.BarraDeEstado));
                pnl_Hora.BackColor = Color.FromArgb(Convert.ToInt32(cl.BarraDeEstado));
                pnl_Usuario.BackColor = Color.FromArgb(Convert.ToInt32(cl.BarraDeEstado));
            }
            this.BackColor = Color.FromArgb(Convert.ToInt32(cl.Fondo));
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                }
            }
            this.pnl_DatosUsuario.Width = this.Width;
            this.pnl_DatosUsuario.Location = new Point(0, this.Height - 25);
            this.pnl_Hora.Location = new Point(this.Width - 500, 0);
            this.pnl_Usuario.Width = this.Width - 500;
            this.pnl_Fecha.Location = new Point(this.Width - 250, 0);
            this.btn_cerrar.Location = new Point(this.Width - 35, 0);
            this.btn_minimizar.Location = new Point(this.Width - 70, 0);
            this.ptb_logoEmpresa.Location = new Point(2, this.Height - 177);
            pnl_Menu inicioSes = new pnl_Menu();
            //InicioSesionForm inicioSes = new InicioSesionForm();
            inicioSes.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            inicioSes.ShowDialog();
            inicioSes.TopMost = true;
            inicioSes.Activate();
        }

        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Usuario u = new Usuario();
            lbl_usuario.Text = u.obtenerUsuario();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbl_fecha.Text = String.Format("{0:MM/dd/yyyy}", DateTime.Now);
            this.lbl_hora.Text = String.Format("{0:hh:mm}", DateTime.Now);
        }

        private void pnl_barraTitulo_Paint(object sender, PaintEventArgs e)
        {
            DateTime fecha = DateTime.Now;
            this.lbl_fecha.Text = String.Format("{0:MM/dd/yyyy}", DateTime.Now);
            this.lbl_hora.Text = String.Format("{0:HH:mm}", DateTime.Now);
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
        }

        private void almacenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario inc = new Usuario();
            int intCodigoUsuario = inc.obtenerCodigoUsuario();
            ConsultaAgencias frm = new ConsultaAgencias(intCodigoUsuario, this) ;
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();
        }

        private void tiposDeTransferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario inc = new Usuario();
            int intCodigoUsuario = inc.obtenerCodigoUsuario();
            ConsultaTipotransferencia frm = new ConsultaTipotransferencia(intCodigoUsuario, this);
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();
        }

        private void cambioDeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaColores frm = new ConsultaColores();
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seguridad2._0.MDIPrincipalSeguridad frm = new Seguridad2._0.MDIPrincipalSeguridad();
            frm.Show();
            Application.DoEvents();
        }

        private void tipoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Usuario inc = new Usuario();
            int intCodigoUsuario = inc.obtenerCodigoUsuario();
            dataTipoEmpleado frm = new dataTipoEmpleado(intCodigoUsuario, this);
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();*/
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            /*Usuario inc = new Usuario();
            int intCodigoUsuario = inc.obtenerCodigoUsuario();
            empleadoData frm = new empleadoData(intCodigoUsuario, this);
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();*/

        }

        private void tipoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Usuario inc = new Usuario();
            int intCodigoUsuario = inc.obtenerCodigoUsuario();

            ConsultaTipoDeCuenta frm = new ConsultaTipoDeCuenta(intCodigoUsuario, this);
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();*/
        }

        private void bancosExternosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Usuario inc = new Usuario();
            int intCodigoUsuario = inc.obtenerCodigoUsuario();
            ConsultaBancosExternos frm = new ConsultaBancosExternos(intCodigoUsuario, this);
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();*/
        }

        private void tipoDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario inc = new Usuario();
            int intCodigoUsuario = inc.obtenerCodigoUsuario();
            consultaMantenimientoTipodeCambio frm = new consultaMantenimientoTipodeCambio(intCodigoUsuario, this);
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();
        }

        private void tipoMonedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario inc = new Usuario();
            int intCodigoUsuario = inc.obtenerCodigoUsuario();
            cnsultaMantenimientoMoneda frm = new cnsultaMantenimientoMoneda(intCodigoUsuario, this);
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();
        }

        /*----------------EJEMPLO PARA ABRIR UN FORM
         
        private void consultarModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz_Consultar_Modulos frm = new Interfaz_Consultar_Modulos();
            frm.MdiParent = this;
            frm.Show();
            Application.DoEvents();
        }
         */
    }
}
