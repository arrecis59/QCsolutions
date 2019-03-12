using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace CapaDatosOpciones
{
    public class ConexionBDOpciones
    {
        public string nombreDns()
        {
            string nDns = "dsn=colchoneria";
            return nDns;
        }

        public void Comando(string sentenciaAE, string msgExito, string msgError)
        {
            try
            {
                using (var conn = new OdbcConnection(nombreDns()))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = sentenciaAE;
                            cmd.ExecuteNonQuery();
                            if(msgExito != "")
                            {
                                MessageBox.Show(msgExito, "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                if(msgError != "")
                {
                    MessageBox.Show(msgError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

    }
}
