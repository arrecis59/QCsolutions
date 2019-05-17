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
            String dato = "";
            Empleado empleado = null;
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        empleado = new Empleado();
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT id_empleado, nombre, apellido_1, apellido_2, correo, tipo_empleado " +
                                "FROM tbl_empleado WHERE gestion = 1 AND id_empleado = " + id_empleado + ";";
                            Reader = cmd.ExecuteReader();
                            dato = Reader["id_empleado"].ToString();
                            empleado.idEmpleado = Convert.ToInt32(dato);
                            dato = Reader["nombre"].ToString();
                            empleado.nombre = dato;
                            dato = Reader["apellido_1"].ToString();
                            empleado.apellido1 = dato;
                            dato = Reader["apellido_2"].ToString();
                            empleado.apellido2 = dato;
                            dato = Reader["correo"].ToString();
                            empleado.correo = dato;
                            dato = Reader["tipo_empleado"].ToString();
                            empleado.tipo_empleado = Convert.ToInt32(dato);

                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }

            return empleado;
        }
    }
}
