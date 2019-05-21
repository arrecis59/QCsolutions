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
    class TransaccionEstadoGestion
    {

        public static EstadoGestion consultarEstado(int idEstado)
        {
            String[] dato = new string[3];
            EstadoGestion estado = new EstadoGestion();
            try
            {
                using (var conn = new OdbcConnection("dns=colchoneria"))
                {
                    OdbcDataReader reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT id_estado_estado, nombre, descripcion " +
                                " FROM tbl_estado_gestion " +
                                "WHERE status = 1 AND id_estado_gestion = " + idEstado.ToString() + ";";
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                dato[0] = reader["id_estado_gestion"].ToString();
                                dato[1] = reader["nombre"].ToString();
                                dato[2] = reader["descripcion"].ToString();
                            }
                        }
                    }
                    conn.Close();
                }
                estado.idEstadoGestion = Convert.ToInt32(dato[0]);
                estado.nombre = dato[1];
                estado.descripcion = dato[2];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error al consultar estado de gestion.");
                return null;
            }
            return estado;
        }

        public bool insertarEstadoGestion(EstadoGestion estado)
        {
            if (validacion(estado))
            {
                String[] motivoArray = new string[5];
                string atributos = " id_motivo_gestion, nombre, descripcion, status ";
                try
                {
                    using (var conn = new OdbcConnection("dns=colchoneria"))
                    {
                        conn.Open();
                        {
                            using (var cmd = conn.CreateCommand())
                            {
                                cmd.CommandText = "INSERT INTO tbl_estado_gestion( " + atributos + " ) " +
                                    "VALUES ( " + estado.cadenaValor() + ", 1 ) ";
                                cmd.ExecuteNonQuery();
                            }
                        }
                        conn.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Error al insertar motivo de gestion.");
                    return false;
                }
            }
            MessageBox.Show("Ingreso exitoso.");
            return true;
        }

        public void cargaComboBox(ComboBox comboBox)
        {
            String[] dato = new string[2];
            try
            {
                using (var conn = new OdbcConnection("dns=colchoneria"))
                {
                    OdbcDataReader reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT id_estado_gestion, nombre FROM tbl_estado_gestion" +
                                "WHERE status = 1;";
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                dato[0] = reader["nombre"].ToString();
                                dato[1] = reader["id_motivo_gestion"].ToString();

                                comboBox.Items.Add(new ComboBoxItem(dato[0], Convert.ToInt32(dato[1])));
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

        private bool validacion(EstadoGestion estado)
        {
            if (estado.idEstadoGestion == 0)
                return false;
            if (estado.nombre == null)
                return false;
            if (estado.descripcion == null)
                return false;
            return true;
        }
    }
}
