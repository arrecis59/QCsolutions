using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaDatosCreacionDeCuentas
{
    public class ClaseCapaDatosCreacionDeCuentas
    {
        public string[] cargarDatosATextboxCuentas(string codigo)
        {
            string[] datos;
            datos = new string[9];
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM tbl_cuenta WHERE id_cuenta = " + codigo + ";";
                            //cmd.CommandText = "SELECT tbl_aplicacion.PK_Api_codigo, tbl_aplicacion.api_descripcion , tbl_modulo.modulo_nombre FROM tbl_modulo, tbl_aplicacion WHERE tbl_modulo.PK_Modulo_codigo = tbl_aplicacion.FK_Codigo_modulo AND tbl_aplicacion.PK_Api_codigo = " + codigoapi + " AND api_estado = 1";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos[0] = (Reader["id_cuenta"].ToString());
                                datos[1] = (Reader["numero_de_cuenta"].ToString());
                                datos[2] = (Reader["fecha_creacion"].ToString());
                                datos[3] = (Reader["saldo"].ToString());
                                datos[4] = (Reader["FK_id_tipo_cuenta"].ToString());
                                datos[5] = (Reader["FK_id_empleado"].ToString());
                                datos[6] = (Reader["FK_id_agencia"].ToString());
                                datos[7] = (Reader["FK_id_moneda"].ToString());
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
            return datos;
        }

        // Carga datos del combobox al textbox dle cliente
        public string[] cargarDatosATextboxClientes(string codigo)
        {
            string[] datos;
            datos = new string[10];
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM tbl_cliente WHERE id_cliente = " + codigo + ";";
                            //cmd.CommandText = "SELECT tbl_aplicacion.PK_Api_codigo, tbl_aplicacion.api_descripcion , tbl_modulo.modulo_nombre FROM tbl_modulo, tbl_aplicacion WHERE tbl_modulo.PK_Modulo_codigo = tbl_aplicacion.FK_Codigo_modulo AND tbl_aplicacion.PK_Api_codigo = " + codigoapi + " AND api_estado = 1";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos[0] = (Reader["id_cliente"].ToString());
                                datos[1] = (Reader["DPI"].ToString());
                                datos[2] = (Reader["nombre"].ToString());
                                datos[3] = (Reader["apellido_1"].ToString());
                                datos[4] = (Reader["telefono"].ToString());
                                datos[5] = (Reader["celular"].ToString());
                                datos[6] = (Reader["correo"].ToString());
                                datos[7] = (Reader["fecha_nacimiento"].ToString());
                                datos[8] = (Reader["genero"].ToString());
                                datos[9] = (Reader["nit"].ToString());
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
            return datos;
        }
    }
}
