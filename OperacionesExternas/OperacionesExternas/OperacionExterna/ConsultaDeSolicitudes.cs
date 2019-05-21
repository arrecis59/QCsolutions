using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaOperacionesExternas;
using MultiUsos;

namespace OperacionesExternas.OperacionExterna
{
    public partial class ConsultaDeSolicitudes : Form
    {
        public ConsultaDeSolicitudes()
        {
            InitializeComponent();
        }

        string sentenciaConsulta = "id_solicitud_Conciliacion as Codigo, fecha as Fecha, estado as Estado, FK_id_transferencia_externa as CodigoDeTransferencia";
        string tabla = "tbl_solicitud_compensacion";

        private void ConsultaDeSolicitudes_Load(object sender, EventArgs e)
        {
            cbo_TipoBusqueda.SelectedIndex = 0;
            ClaseMultiusos cm = new ClaseMultiusos();
            DataSet ds = cm.LlenarGridWOStatus(sentenciaConsulta, tabla);
            dtg_Cuentas.DataSource = ds.Tables[0];
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txt_Busqueda_TextChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            if (txt_Busqueda.Text == "")
            {
                DataSet ds = cm.LlenarGridWOStatus(sentenciaConsulta, tabla);
                dtg_Cuentas.DataSource = ds.Tables[0];
            }
            else if(cbo_TipoBusqueda.Text == "Codigo")
            {
                DataSet ds = cm.LlenarGridWhereLike(sentenciaConsulta, tabla, "id_solicitud_Conciliacion", txt_Busqueda.Text);
                dtg_Cuentas.DataSource = ds.Tables[0];
            }
            else if (cbo_TipoBusqueda.Text == "Codigo de Transferencia")
            {
                DataSet ds = cm.LlenarGridWhereLike(sentenciaConsulta, tabla, "FK_id_transferencia_externa", txt_Busqueda.Text);
                dtg_Cuentas.DataSource = ds.Tables[0];
            }
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            DataSet ds = cm.LlenarGridWOStatus(sentenciaConsulta, tabla);
            dtg_Cuentas.DataSource = ds.Tables[0];
            txt_Busqueda.Text = "";
        }
    }
}
