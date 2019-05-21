using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiUsos;

namespace CreacionDeCuentas
{
    public partial class AsignacionDeClientesAOrganizaciones : Form
    {
        public AsignacionDeClientesAOrganizaciones()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AsignacionDeClientesAOrganizaciones_Load(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            cm.cargarDatosACombobox(cbo_org, "nombre_organizacion", "tbl_organizacion_clientes");
            cm.cargarDatosACombobox(cbo_cliente, "nombre", "tbl_cliente");
        }

        private void txt_org_TextChanged(object sender, EventArgs e)
        {
            cargarDTG();
        }

        public void cargarDTG()
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            DataSet ds = cm.LlenarGridWhere("id_cliente as codigo, DPI as DPI, nombre as Nombre, apellido_1 as Apellido, telefono as Telefono, celular as Celular, correo as Correo, fecha_nacimiento as FecNac, nit as NIT", "tbl_cliente, tbl_cliente_has_tbl_organizacion_clientes", "id_cliente", "FK_id_cliente AND FK_id_Organizacion =" + txt_org.Text + "");
            dtg_Clientes.DataSource = ds.Tables[0];
        }

        private void cbo_org_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_organizacion", "tbl_organizacion_clientes", "nombre_organizacion", cbo_org.Text);
            txt_org.Text = codigo;
        }

        private void cbo_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            string codigo = "";
            codigo = cm.ExtraerCodigo("id_cliente", "tbl_cliente", "nombre", cbo_cliente.Text);
            txt_cliente.Text = codigo;
        }

        private void btn_masAgregar_Click(object sender, EventArgs e)
        {
            ClaseMultiusos cm = new ClaseMultiusos();
            try
            {
                cm.InsertarDatosAplicaciones("tbl_cliente_has_tbl_organizacion_clientes", txt_cliente.Text + "," + txt_org.Text);
                MessageBox.Show("Cliente agregado a la organizacion \"" + cbo_org.Text + "\"");
                cargarDTG();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dtg_Clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtg_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = dtg_Clientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            ClaseMultiusos cm = new ClaseMultiusos();
            cm.EliminarDatos("tbl_cliente_has_tbl_organizacion_clientes", "FK_id_Cliente", codigo + " AND FK_id_Organizacion = " + txt_org.Text);
            cargarDTG();
        }

        private void btn_masOrg_Click(object sender, EventArgs e)
        {
            AddOrg form = new AddOrg();
            form.ShowDialog();
            ClaseMultiusos cm = new ClaseMultiusos();
            cbo_org.DataSource = null;
            cbo_org.Items.Clear();
            cm.cargarDatosACombobox(cbo_org, "nombre_organizacion", "tbl_organizacion_clientes");
        }

        private void btn_masCliente_Click(object sender, EventArgs e)
        {
            AddCliente form = new AddCliente();
            form.ShowDialog();
            ClaseMultiusos cm = new ClaseMultiusos();
            cbo_cliente.DataSource = null;
            cbo_cliente.Items.Clear();
            cm.cargarDatosACombobox(cbo_cliente, "nombre", "tbl_cliente");
        }
    }
}
