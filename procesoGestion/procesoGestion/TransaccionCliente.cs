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
    class TransaccionCliente
    {
        public static Cliente consultarCliente(int id_cliente)
        {
            String dato = "";
            Cliente cliente = null;
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        cliente = new Cliente();
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT id_cliente, DPI, nombre, apellido_1, apellido_2, telefono, celular, " +
                                "correo, fecha_nacimiento, genero, nit " +
                                "FROM tbl_cliente WHERE status = 1 AND id_cliente = " + id_cliente + ";";
                            Reader = cmd.ExecuteReader();
                            dato = Reader["id_cliente"].ToString();
                            cliente.idcliente= Convert.ToInt32(dato);
                            dato = Reader["DPI"].ToString();
                            cliente.DPI = dato;
                            dato = Reader["nombre"].ToString();
                            cliente.nombre = dato;
                            dato = Reader["apellido_1"].ToString();
                            cliente.apellido1 = dato;
                            dato = Reader["apellido_2"].ToString();
                            cliente.apellido2 = dato;
                            dato = Reader["telefono"].ToString();
                            cliente.telefono = dato;
                            dato = Reader["celular"].ToString();
                            cliente.celular = dato;
                            dato = Reader["correo"].ToString();
                            cliente.correo = dato;
                            dato = Reader["fecha_nacimiento"].ToString();
                            cliente.fecha_nac = Convert.ToDateTime(dato);
                            dato = Reader["genero"].ToString();
                            cliente.genero = dato;
                            dato = Reader["nit"].ToString();
                            cliente.nit = dato;

                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");            }

            return cliente;
        }
        /*
        public static Cliente consultarCliente(String dpi)
        {
            String dato = "";
            Cliente cliente = null;
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        cliente = new Cliente();
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT id_cliente, DPI, nombre, apellido_1, apellido_2, telefono, celular, " +
                                "correo, fecha_nacimiento, genero, nit " +
                                " FROM tbl_cliente WHERE status = 1 AND DPI = " + dpi + " LIMIT 1";
                            Reader = cmd.ExecuteReader();
                            dato = Reader["id_cliente"].ToString();
                            cliente.idcliente = Convert.ToInt32(dato);
                            dato = Reader["DPI"].ToString();
                            cliente.DPI = dato;
                            dato = Reader["nombre"].ToString();
                            cliente.nombre = dato;
                            dato = Reader["apellido_1"].ToString();
                            cliente.apellido1 = dato;
                            dato = Reader["apellido_2"].ToString();
                            cliente.apellido2 = dato;
                            dato = Reader["telefono"].ToString();
                            cliente.telefono = dato;
                            dato = Reader["celular"].ToString();
                            cliente.celular = dato;
                            dato = Reader["correo"].ToString();
                            cliente.correo = dato;
                            dato = Reader["fecha_nacimiento"].ToString();
                            cliente.fecha_nac = Convert.ToDateTime(dato);
                            dato = Reader["genero"].ToString();
                            cliente.genero = dato;
                            dato = Reader["nit"].ToString();
                            cliente.nit = dato;

                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }

            return cliente;
        }
        */

        /*public static Cliente consultaGes(string dpi) { 
            String[] dato = new string[8];
            Cliente cliente = new Cliente();
            Gestion gestion = new  Gestion();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT id_cliente, DPI, nombre, apellido_1, apellido_2, telefono, celular, " +
                                "correo, fecha_nacimiento, genero, nit " +
                                " FROM tbl_cliente WHERE status = 1 AND DPI = " + dpi + " LIMIT 1";
                            Reader = cmd.ExecuteReader();
                            dato[0] = Reader["id_cliente"].ToString();
                            cliente.idcliente = Convert.ToInt32(dato[0]);
                            dato[1] = Reader["DPI"].ToString();
                            cliente.DPI = dato[1];
                            dato[2] = Reader["nombre"].ToString();
                            cliente.nombre = dato[2];
                            dato[3] = Reader["apellido_1"].ToString();
                            cliente.apellido1 = dato[3];
                            dato[4] = Reader["apellido_2"].ToString();
                            cliente.apellido2 = dato[4];
                            dato[5] = Reader["telefono"].ToString();
                            cliente.telefono = dato[5];
                            dato[6] = Reader["celular"].ToString();
                            cliente.celular = dato[6];
                            dato[7] = Reader["correo"].ToString();
                            cliente.correo = dato[7];
                            dato[8] = Reader["fecha_nacimiento"].ToString();
                            cliente.fecha_nac = Convert.ToDateTime(dato[8]);
                            dato[9] = Reader["genero"].ToString();
                            cliente.genero = dato[9];
                            dato[10] = Reader["nit"].ToString();
                            cliente.nit = dato[10];
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
            return cliente;
        }*/

        ///////////////
        public static Cliente consultaGes(string dpi)
        {
            string[] dato = new string[11];
            Cliente cliente = new Cliente();
            Gestion gestion = new Gestion();
            //datos = new string[11];
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT id_cliente, DPI, nombre, apellido_1, apellido_2, telefono, celular, " +
                                "correo, fecha_nacimiento, genero, nit " +
                                " FROM tbl_cliente WHERE status = 1 AND DPI = " + dpi + " LIMIT 1";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                dato[0] = Reader["id_cliente"].ToString();
                                dato[1] = Reader["DPI"].ToString();
                                dato[2] = Reader["nombre"].ToString();
                                dato[3] = Reader["apellido_1"].ToString();
                                dato[4] = Reader["apellido_2"].ToString();
                                dato[5] = Reader["telefono"].ToString();
                                dato[6] = Reader["celular"].ToString();
                                dato[7] = Reader["correo"].ToString();
                                dato[8] = Reader["fecha_nacimiento"].ToString();
                                dato[9] = Reader["genero"].ToString();
                                dato[10] = Reader["nit"].ToString();
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
            cliente.idcliente = Convert.ToInt32(dato[0]);
            cliente.DPI = dato[1];
            cliente.nombre = dato[2];
            cliente.apellido1 = dato[3];
            cliente.apellido2 = dato[4];
            cliente.telefono = dato[5];
            cliente.celular = dato[6];
            cliente.correo = dato[7];
            cliente.fecha_nac = Convert.ToDateTime(dato[8]);
            cliente.genero = dato[9];
            cliente.nit = dato[10];
            return cliente;
        }
    }
}
