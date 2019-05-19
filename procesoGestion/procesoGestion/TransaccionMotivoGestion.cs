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
        public static MotivoGestion consultarMotivo(int idGestion)
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
                                "WHERE status = 1 AND id_motivo = "+ idGestion.ToString() +";";
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                dato[0] = reader["id_motivo"].ToString();
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

        public bool insertar motivoGestion(MotivoGestion motivo)
        {
            if (validacion(motivo))
            {
                String 
            }
        }

        private bool validacion(MotivoGestion motivo)
        {
            if (motivo.idMotivoGestion == null)
                return false;
            if (motivo.nombre == null)
                return false;
            if (motivo.tipoEmpleado == null)
                return false;
            if (motivo.descripcion == null)
                return false;
            return true;
        }
    }
}
