using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CrystalDecisions.CrystalReports.Engine;

namespace DLL__Reporteador
{
    public partial class AdministradorDeReportes : Form
    {
        public static int intCodigoAplicacion = 0;
        public static int intCodigoModulo = 0;
        public static DataTable dtReal;
        public static ReportDocument rptDocument;


        public AdministradorDeReportes()
        {
            InitializeComponent();
            if (chk_XAplicacion.Checked == true)
            {
                CargarDataGridConAplicacion();
            }
            else if (chk_XModulo.Checked == true)
            {
                CargarDataGridConModulos();
            }
        }

        private void chk_XAplicacion_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_XAplicacion.Checked == true)
            {
                chk_XModulo.Checked = false;
            }
            else if(chk_XModulo.Checked == false && chk_XAplicacion.Checked == false)
            {
                chk_XAplicacion.Checked = true;
            }
            if (chk_XAplicacion.Checked == true)
            {
                CargarDataGridConAplicacion();
            }
            else if (chk_XModulo.Checked == true)
            {
                CargarDataGridConModulos();
            }
        }

        public void CargarDataGridConAplicacion()
        {
            DataSet ds = new DataSet();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT PK_Id_Documento, Nombre_doc, Ruta, FK_Api_codigo FROM tbl_doc_asociado WHERE FK_Api_codigo = " + intCodigoAplicacion + ";";
                            //cmd.CommandText = "SELECT * FROM tbl_aplicacion";
                            OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            m_datos.Fill(ds);
                            dtg_Reportes.DataSource = ds.Tables[0];
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public void CargarDataGridConModulos()
        {
            DataSet ds = new DataSet();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT tbl_doc_asociado.PK_Id_Documento, tbl_doc_asociado.Nombre_doc, tbl_doc_asociado.Ruta, tbl_doc_asociado.FK_Api_codigo FROM tbl_doc_asociado, tbl_aplicacion WHERE tbl_aplicacion.FK_Codigo_modulo = " + intCodigoModulo + " AND tbl_aplicacion.PK_Api_codigo =  tbl_doc_asociado.FK_Api_codigo;";
                            //cmd.CommandText = "SELECT * FROM tbl_aplicacion";
                            OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            m_datos.Fill(ds);
                            dtg_Reportes.DataSource = ds.Tables[0];
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public int getCodigoModuloFromAplicacion(int intCodigoAplicacion2)
        {
            int intCodigoModulo = 0;
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT FK_Codigo_modulo FROM tbl_aplicacion WHERE PK_Api_codigo = " + intCodigoAplicacion2 + ";";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                intCodigoModulo = Convert.ToInt32(Reader["FK_Codigo_modulo"]);
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
            return intCodigoModulo;
        }

        public void getDatosNecesariosParaReportes(int intCodigoAplicacion2)
        {
            intCodigoAplicacion = intCodigoAplicacion2;
            intCodigoModulo = getCodigoModuloFromAplicacion(intCodigoAplicacion2);
        }

        public void getDatosNecesariosParaReportes2(DataTable dt, ReportDocument rptD)
        {
            dtReal = dt;
            rptDocument = rptD;
        }

        private void chk_XModulo_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_XModulo.Checked == true)
            {
                chk_XAplicacion.Checked = false;
            }
            else if(chk_XModulo.Checked == false && chk_XAplicacion.Checked == false)
            {
                chk_XModulo.Checked = true;
            }
            //MessageBox.Show(intCodigoAplicacion.ToString() + intCodigoModulo.ToString());
            if (chk_XAplicacion.Checked == true)
            {
                CargarDataGridConAplicacion();
            }
            else if (chk_XModulo.Checked == true)
            {
                CargarDataGridConModulos();
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AdministradorDeReportes_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(intCodigoAplicacion.ToString() + intCodigoModulo.ToString());
        }

        public void cargarDatosModuloBusqueda(string strNombreDoc)
        {

            DataSet ds = new DataSet();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT tbl_doc_asociado.PK_Id_Documento, tbl_doc_asociado.Nombre_doc, tbl_doc_asociado.Ruta, tbl_doc_asociado.FK_Api_codigo FROM tbl_doc_asociado, tbl_aplicacion WHERE tbl_aplicacion.FK_Codigo_modulo = " + intCodigoModulo + " AND tbl_aplicacion.PK_Api_codigo =  tbl_doc_asociado.FK_Api_codigo AND tbl_doc_asociado.Nombre_doc LIKE '"+strNombreDoc+"%';";
                            OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            m_datos.Fill(ds);
                            dtg_Reportes.DataSource = ds.Tables[0];
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void cargarDataGridConAplicacionBusqueda(string strNombreDoc)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT PK_Id_Documento, Nombre_doc, Ruta, FK_Api_codigo FROM tbl_doc_asociado WHERE FK_Api_codigo = " + intCodigoAplicacion + " AND Nombre_doc LIKE '" + strNombreDoc + "%';";
                            OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            m_datos.Fill(ds);
                            dtg_Reportes.DataSource = ds.Tables[0];
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_Busqueda_TextChanged(object sender, EventArgs e)
        {
            if (txt_Busqueda.Text != "")
            {
                if (chk_XAplicacion.Checked == true)
                {
                    cargarDataGridConAplicacionBusqueda(txt_Busqueda.Text);
                }
                else if (chk_XModulo.Checked == true)
                {
                    cargarDatosModuloBusqueda(txt_Busqueda.Text);
                }
            }
        }

        public string strRutaReference;

        private void dtg_Reportes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ////////////////////
            try
            {
                if (dtg_Reportes.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dtg_Reportes.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dtg_Reportes.Rows[selectedrowindex];
                    strRutaReference = Convert.ToString(selectedRow.Cells[2].Value);
                    Visualizador vs = new Visualizador();
                    vs.AbrirReporteCreado(strRutaReference);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void brn_generarRpt_Click(object sender, EventArgs e)
        {
            Visualizador vs = new Visualizador();
            vs.generarReporte(dtReal, rptDocument);
        }
    }
}
