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
    class TransaccionEmpleado
    {
        public static Empleado consultarEmpleado(int id_empleado)
        {
            String[] dato = new string [6];
            Empleado empleado = null;
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader reader;
                    conn.Open();
                    {
                        empleado = new Empleado();
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT id_empleado, nombre, apellido_1, apellido_2, correo, FK_id_tipo_empleado " +
                                "FROM tbl_empleado WHERE id_empleado = " + id_empleado + " AND status = 1;"; //validar gestion
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                dato[0] = reader["id_empleado"].ToString();
                                dato[1] = reader["nombre"].ToString();
                                dato[2] = reader["apellido_1"].ToString();
                                dato[3] = reader["apellido_2"].ToString();
                                dato[4] = reader["correo"].ToString();
                                dato[5] = reader["FK_id_tipo_empleado"].ToString();
                            }
                        }
                    }
                    conn.Close();
                }

                empleado.idEmpleado = Convert.ToInt32(dato[0]);
                empleado.nombre = dato[1];
                empleado.apellido1 = dato[2];
                empleado.apellido2 = dato[3];
                empleado.correo = dato[4];
                empleado.tipo_empleado = Convert.ToInt32(dato[5]);  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }

            return empleado;
        }
    }
}
