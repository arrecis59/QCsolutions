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
            String dato = "";
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
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        gestion = new Gestion();
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT id_gestion, DATE_FORMAT(fecha,'%d/%m/%Y'), DATE_FORMAT(fecha,'%d/%m/%Y'),estado, prioridad, " +
                                "motivo, descripcion, empl_servicio, empl_solucion, id_cliente" +
                                "FROM tbl_gestion WHERE id_gestion = " + id_gestion + ";";

                            //validar que exista el registro.
                            Reader = cmd.ExecuteReader();
                            dato = Reader["id_gestion"].ToString();
                            gestion.idGestion = Convert.ToInt32(dato);
                            dato = Reader["fecha"].ToString();
                            gestion.fecha_gestion = Convert.ToDateTime(dato);
                            dato = Reader["estado"].ToString();
                            estado = Convert.ToInt32(dato);
                            dato = Reader["motivo"].ToString();
                            motivo = Convert.ToInt32(dato);
                            dato = Reader["descripcion"].ToString();
                            gestion.descripcion = dato;
                            dato = Reader["empl_servicio"].ToString();
                            empl_servicio = Convert.ToInt32(dato); 
                            dato = Reader["empl_solucion"].ToString();
                            empl_solucion = Convert.ToInt32(dato);
                            dato = Reader["id_cliente"].ToString();
                            cliente = Convert.ToInt32(dato);
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

        public void consultaGes(string id_gestion)
        {
            string[] datos;
            datos = new string[9];
            Gestion gestion = new Gestion();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT id_gestion, DATE_FORMAT(fecha,'%d/%m/%Y'), DATE_FORMAT(fecha_solucion,'%d/%m/%Y'),estado, prioridad, " +
                                "motivo, descripcion, empl_servicio, empl_solucion, id_cliente" +
                                "FROM tbl_gestion WHERE id_gestion = " + id_gestion + ";";
                            //cmd.CommandText = "SELECT * FROM tbl_cuenta WHERE id_cuenta = " + codigo + ";";
                            //cmd.CommandText = "SELECT tbl_aplicacion.PK_Api_codigo, tbl_aplicacion.api_descripcion , tbl_modulo.modulo_nombre FROM tbl_modulo, tbl_aplicacion WHERE tbl_modulo.PK_Modulo_codigo = tbl_aplicacion.FK_Codigo_modulo AND tbl_aplicacion.PK_Api_codigo = " + codigoapi + " AND api_estado = 1";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos[0] = (Reader["id_gestion"].ToString());
                                datos[1] = (Reader["fecha"].ToString());
                                datos[2] = (Reader["fecha_solucion"].ToString());
                                datos[3] = (Reader["estado"].ToString());
                                datos[4] = (Reader["prioridad"].ToString());
                                datos[5] = (Reader["motivo"].ToString());
                                datos[5] = (Reader["descripcion"].ToString());
                                datos[6] = (Reader["empl_servicio"].ToString());
                                datos[7] = (Reader["empl_solucion"].ToString());
                                datos[8] = (Reader["id_clinte"].ToString());
                                //datos[8] = (Reader["tbl_organizacion_clientes_id_organizacion"].ToString());
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

        }
    }
}
