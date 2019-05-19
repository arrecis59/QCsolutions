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
        public static Cliente consultarCliente(string dpi)
        {
            string[] dato = new string[11];
            Cliente cliente = new Cliente();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
            return cliente;
        }

        public static Cliente consultarCliente(int id_cliente)
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
                                "FROM tbl_cliente WHERE status = 1 AND id_cliente = " + id_cliente.ToString() + " LIMIT 1";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
            return cliente;
        }

        public Boolean insertarCliente(Cliente cliente)
        {
            /**
             * Campos obligatorios
             * -id_cliente
             * -DPI
             * -nombre
             * -apellido1
             * -telefono
             * -correo
             * -fecha_nacimiento
             * -genero
             **/
             if (validacion(cliente))
            {
                String[] clienteArray = new string[11];
                string atributos = " id_cliente, DPI, nombre, apellido1_, apellido_2, telefono, celular, correo, fecha_nacimiento, genero, nit, status ";
                try
                {

                    using (var conn = new OdbcConnection("dns=colchoneria"))
                    {
                        conn.Open();
                        {
                            using (var cmd = conn.CreateCommand())
                            {
                                cmd.CommandText = "INSERT INTO (" + atributos + ") " +
                                    "VALUES ( "+ cliente.ToString() +" );";
                            }
                        }
                        conn.Close();
                    }

                } catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error al crear cliente.");
                    return false;
                }
            }
            MessageBox.Show("Ingresado exitosamente.");
            return true;
        }

        private bool validacion(Cliente cliente)
        {
            if (cliente.idcliente == 0)
                return false;
            if (cliente.DPI == null)
                return false;
            if (cliente.nombre == null)
                return false;
            if (cliente.apellido1 == null)
                return false;
            if (cliente.telefono == null)
                return false;
            if (cliente.correo == null)
                return false;
            if (cliente.fecha_nac == null)
                return false;
            if (cliente.genero == null)
                return false;
            return true;
        }
    }
}
