using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms; 

namespace CapaDatosPagoAOrganizaciones
{
    public class DatosPagoAOrganizaciones
    {

        // Carga datos del combobox al textbox de la cuenta
        public string[] cargarDatosATextbox_1(string codigo)
        {
            string[] datos;
            datos = new string[5];
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM tbl_cuenta WHERE id_cuenta = " + codigo + ";";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos[0] = (Reader["id_cuenta"].ToString());
                                datos[1] = (Reader["numero_de_cuenta"].ToString());
                                datos[2] = (Reader["FK_id_tipo_cuenta"].ToString());
                                datos[3] = (Reader["FK_id_moneda"].ToString());
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
            return datos;
        }
    }
}
