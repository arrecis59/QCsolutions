﻿using System;
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
        public Tuple<OdbcConnection, OdbcTransaction> ObtenerConexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=colchoneria");
            conectar.Open();
            OdbcTransaction transaction = conectar.BeginTransaction();
            return Tuple.Create(conectar, transaction);
            
        }

        /**
         * Consulta una gestion por llave primaria.
         * */
        public static Gestion consultarGestion(string id_gestion)
        {
            String[] dato = new string[10];
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
                            cmd.CommandText = "SELECT id_gestion, DATE_FORMAT(fecha_servicio,'%d/%m/%Y') AS fecha_servicio, DATE_FORMAT(fecha_solucion,'%d/%m/%Y') AS fecha_solucion, " +
                                "id_estado, prioridad, id_motivo, descripcion, empl_servicio, empl_solucion, id_cliente, " +
                                "FROM tbl_gestion WHERE id_gestion = " + id_gestion + ";";
                            //validar que exista el registro.
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                dato[0] = reader["id_gestion"].ToString();
                                dato[1]= reader["fecha_servicio"].ToString();
                                dato[2] = reader["fecha_solucion"].ToString();
                                dato[3] = reader["id_estado"].ToString();
                                dato[4] = reader["prioridad"].ToString();
                                dato[5] = reader["id_motivo"].ToString();
                                dato[6] = reader["descripcion"].ToString();
                                dato[7] = reader["empl_servicio"].ToString();
                                dato[8] = reader["empl_solucion"].ToString();
                                dato[9] = reader["id_cliente"].ToString();
                            }
                        }
                    }
                    conn.Close();
                }
                gestion.idGestion = Convert.ToInt32(dato[0]);
                gestion.fecha_gestion = Convert.ToDateTime(dato[1]);
                gestion.fecha_solucion = Convert.ToDateTime(dato[2]);
                gestion.estado = TransaccionEstadoGestion.consultarEstado(Convert.ToInt32(dato[3]));
                gestion.prioridad = Convert.ToInt32(dato[4]);
                gestion.motivo = TransaccionMotivoGestion.consultarMotivo(Convert.ToInt32(dato[5]));
                gestion.descripcion = dato[6];
                gestion.empl_servicio = TransaccionEmpleado.consultarEmpleado(Convert.ToInt32(dato[7]));
                //Si no existe = 0
                if (Convert.ToInt32(dato[8]) != 0)
                    gestion.empl_solucion = TransaccionEmpleado.consultarEmpleado(Convert.ToInt32(dato[8]));
                else
                    gestion.empl_solucion = null;
                gestion.cliente = TransaccionCliente.consultarCliente(Convert.ToInt32(dato[9]));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
            return gestion;
        }

        public static bool insertarGestion(Gestion gestion)
        {
            if (validacion(gestion))
            {
                String[] gestionArray = new string[10];
                string atributos = " id_gestion, fecha_servicio, fecha_solucion, id_estado, prioridad, id_motivo, descripcion, empl_servicio, " +
                    "empl_solucion, id_cliente, status ";
                try
                {
                    using (var conn = new OdbcConnection("dsn=colchoneria"))
                    {
                        conn.Open();
                        {
                            using (var cmd = conn.CreateCommand())
                            {
                                cmd.CommandText = "INSERT INTO tbl_gestion ( "+ atributos +" ) " +
                                    "VALUES ("+ gestion.cadenaValor() +", 1)";
                                cmd.ExecuteNonQuery();
                            }
                        }
                        conn.Close();
                    }
                }catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error al crear gestion.");
                    return false;
                }
                return true;
            }
            MessageBox.Show("Faltan valores.");
            return false;
        }

        //public int getMaxId();

        //Mantiene los valores iniciales (not null) de la gestion.
        public bool seguimientoGestion(Gestion gestion)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();
                    {
                        using(var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "UPDATE tbl_gestion " +
                                "SET = " + gestion.getSeguimiento() + " ;";
                            cmd.ExecuteNonQuery();
                        }
                    }
                    conn.Close();
                }
            }catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al actualizar gestion");
                return false;
            }
            return true;
        }

        //Valida que existan los not null.
        private static bool validacion(Gestion gestion) 
        {
            if (gestion.idGestion == 0)
                return false;
            if (gestion.fecha_gestion == null)
                return false;
            if (gestion.empl_servicio.idEmpleado == 0)
                return false;
            if (gestion.cliente.idcliente == 0)
                return false;
            return true;
        }

        //Devuelve datatable con gestiones pendientes.
        public static DataSet llenarDataGrid()
        {
            DataSet ds = new DataSet();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = " SELECT g.id_gestion, CONCAT(e.nombre, \" \", e.apellido_1) AS empleado, " +
                                " CONCAT(c.nombre, \" \", c.apellido_1) AS cliente, g.prioridad, g.descripcion " +
                                " FROM tbl_gestion g, tbl_empleado e, tbl_cliente c " +
                                " WHERE g.empl_servicio = e.id_empleado " +
                                " AND g.id_cliente = c.id_cliente " +
                                " AND g.id_estado = 1 ; ";
                            OdbcDataAdapter datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            datos.Fill(ds);
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ds;
        }
        
    }
}
