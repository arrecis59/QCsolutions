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
    class TransaccionMotivoGestion
    {
        public static MotivoGestion consultarMotivo(int idMotivo)
        {
            String[] dato = new string[4];
            MotivoGestion motivo = new MotivoGestion();
            try
            {
                using (var conn = new OdbcConnection("dns=colchoneria"))
                {
                    OdbcDataReader reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT id_motivo_estado, nombre, tipo_empleado, descripcion " +
                                " FROM tbl_motivo_gestion " +
                                "WHERE status = 1 AND id_motivo_gestion = "+ idMotivo.ToString() +";";
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                dato[0] = reader["id_motivo_gestion"].ToString();
                                dato[1] = reader["nombre"].ToString();
                                dato[2] = reader["tipo_empleado"].ToString();
                                dato[3] = reader["descripcion"].ToString();
                            }
                        }
                    }
                    conn.Close();
                }
                motivo.idMotivoGestion = Convert.ToInt32(dato[0]);
                motivo.nombre = dato[1];
                motivo.tipoEmpleado = Convert.ToInt32(dato[2]);
                motivo.descripcion = dato[3];
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error al consultar motivo de gestion.");
                return null;
            }
            return motivo;
        }

        //Inserta motivo gestion.
        public bool insertarMotivoGestion(MotivoGestion motivo)
        {
            if (validacion(motivo))
            {
                string atributos = " id_motivo_gestion, nombre, tipo_empleado, descripcion, status ";
                try
                {
                    using(var conn = new OdbcConnection("dns=colchoneria"))
                    {
                        conn.Open();
                        {
                            using(var cmd = conn.CreateCommand()){
                                cmd.CommandText = "INSERT INTO  tbl_movimiento_gestion( "+ atributos +" ) " +
                                    "VALUES ( "+ motivo.cadenaValor() + ", 1 ) ";
                                cmd.ExecuteNonQuery();
                            }
                        }
                        conn.Close();
                    }
                } catch(Exception e)
                {
                    MessageBox.Show(e.ToString(), "Error al insertar motivo de gestion.");
                    return false;
                }
            }
            MessageBox.Show("Ingreso exitoso.");
            return true;
        }

        //public void cargaComboBox(ComboBox comboBox)
        //{
        //    comboBox = new ComboBox();
        //    String[] dato = new string[2];
        //    try
        //    {
        //        using (var conn = new OdbcConnection("dns=colchoneria"))
        //        {
        //            OdbcDataReader reader;
        //            conn.Open();
        //            {
        //                using (var cmd = conn.CreateCommand())
        //                {
        //                    cmd.CommandText = "SELECT id_motivo_gestion, nombre FROM tbl_motivo_gestion" +
        //                        "WHERE AND status = 1;";
        //                    reader = cmd.ExecuteReader();
        //                    while (reader.Read())
        //                    {
        //                        dato[0] = reader["nombre"].ToString();
        //                        dato[1] = reader["id_motivo_gestion"].ToString();
        //                        comboBox.Items.Add(new ComboBoxItem(dato[0], Convert.ToInt32(dato[1])));
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.ToString(), "ERROR");
        //    }
        //}

        public static void cargaComboBox(ComboBox comboBox)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT id_motivo_gestion FROM tbl_motivo_gestion ; ";
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                comboBox.Items.Add(reader["id_motivo_gestion"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
                comboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        public static List<ComboBoxItem> getItems()
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            String[] dato = new string[2];
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT id_motivo_gestion, nombre FROM tbl_motivo_gestion " +
                                " WHERE status = 1 ; ";
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                dato[0] = reader["nombre"].ToString();
                                dato[1] = reader["id_motivo_gestion"].ToString();
                                items.Add(new ComboBoxItem(dato[0], Convert.ToInt32(dato[1])));
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR");
                return null;
            }
            return items;
        }

        private bool validacion(MotivoGestion motivo)
        {
            if (motivo.idMotivoGestion == 0)
                return false;
            if (motivo.nombre == null)
                return false;
            if (motivo.tipoEmpleado == 0)
                return false;
            if (motivo.descripcion == null)
                return false;
            return true;
        }
    }
}
