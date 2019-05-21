using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace DatosConsultaSaldos
{
    public class CapaDatosConsultaSaldos
    {
        public DataSet LlenarGridWhere(string CadenaDeCampos, string Tabla, string campoWhere, string DatoAbuscar)
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
                            cmd.CommandText = "SELECT " + CadenaDeCampos + " FROM " + Tabla + " WHERE " + campoWhere + " = " + DatoAbuscar + ";";
                            OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            m_datos.Fill(ds);
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ds;
        }
    }
}
