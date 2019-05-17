using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;

namespace procesoGestion
{
    class TransaccionMotivo
    {
        public void cargaComboBox(ComboBox comboBox, int tipo_empleado)
        {
            try
            {
                using (var conn = new OdbcConnection("dns=colchoneria"))
                {
                    OdbcDataReader reader;
                    conn.Open();
                    {
                        using(var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT id_motivo_gestion, nombre FROM tbl_motivo_gestion" +
                                "WHERE tipo_empleado = "+ tipo_empleado +"AND status = 1;";
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                String texto = reader["nombre"].ToString();
                                int valor = Convert.ToInt32(reader["id_motivo_gestion"].ToString());
                                comboBox.Items.Add(new ComboBoxItem(texto, valor));
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR");
            }
        }
    }
}
