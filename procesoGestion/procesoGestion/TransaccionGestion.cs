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
    class TransaccionGestion
    {
        OdbcTransaction transaction = null;

        public Tuple<OdbcConnection, OdbcTransaction> ObtenerConexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=colchoneria");
            conectar.Open();
            OdbcTransaction transaction = conectar.BeginTransaction();
            return Tuple.Create(conectar, transaction);
            
        }

        public static Gestion consultarGestion(string id_gestion)
        {
            String[] dato = new string[8];
            int empl_servicio = 0;
            int empl_solucion = 0;
            int cliente = 0;
            int motivo = 0;
            int estado = 0;
            Gestion gestion = null;
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader reader;
                    conn.Open();
                    {
                        gestion = new Gestion();
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT id_gestion, DATE_FORMAT(fecha,'%d/%m/%Y'), DATE_FORMAT(fecha_solucion,'%d/%m/%Y'),estado, prioridad, " +
                                "motivo, descripcion, empl_servicio, empl_solucion, id_cliente" +
                                "FROM tbl_gestion WHERE id_gestion = " + id_gestion + ";";
                            //validar que exista el registro.
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                dato[0] = reader["id_gestion"].ToString();
                                gestion.idGestion = Convert.ToInt32(dato[0]);
                                dato[1]= reader["fecha"].ToString();
                                gestion.fecha_gestion = Convert.ToDateTime(dato[1]);
                                dato[2] = reader["estado"].ToString();
                                estado = Convert.ToInt32(dato[2]);
                                dato[3] = reader["motivo"].ToString();
                                motivo = Convert.ToInt32(dato[3]);
                                dato[4] = reader["descripcion"].ToString();
                                gestion.descripcion = dato[4];
                                dato[5] = reader["empl_servicio"].ToString();
                                empl_servicio = Convert.ToInt32(dato[5]);
                                dato[6] = reader["empl_solucion"].ToString();
                                empl_solucion = Convert.ToInt32(dato[6]);
                                dato[7] = reader["id_cliente"].ToString();
                                cliente = Convert.ToInt32(dato[7]);
                            }
                        }
                    }
                    conn.Close();
                }
                //Siempre tiene empleado servicio.
                gestion.empl_servicio = TransaccionEmpleado.consultarEmpleado(empl_servicio);
                //Empleado solucion si no existe = 0.
                if(empl_solucion != 0)
                {
                    gestion.empl_solucion = TransaccionEmpleado.consultarEmpleado(empl_solucion);
                } else
                {
                    gestion.empl_solucion = null;
                }
                //Cliente
                gestion.cliente = TransaccionCliente.consultarCliente(cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
            return gestion;
        }
        
    }
}
