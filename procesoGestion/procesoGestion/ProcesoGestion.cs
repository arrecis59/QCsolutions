﻿using System;
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
        //ComboBox cmb_motivo_gestion = ComboBoxItem.llenarCmb(TransaccionMotivoGestion.getItems());

        public frm_proceso_gestion()
        {
            InitializeComponent();

            //Inicializacion
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

        private void frm_proceso_gestion_Load(object sender, EventArgs e)
        {
            txt_fecha.Text = fechaActual.ToLongDateString();
            TransaccionMotivoGestion.cargaComboBox(cmb_motivo);
            TransaccionEstadoGestion.cargaComboBox(cmb_estado);
            llenarPrioridad(cmb_prioridad);
        }

        private void llenarPrioridad(ComboBox cmb)
        {
            cmb.Items.Add("5");
            cmb.Items.Add("4");
            cmb.Items.Add("3");
            cmb.Items.Add("2");
            cmb.Items.Add("1");
            cmb.SelectedIndex = 0;
        }

        private void btn_cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
