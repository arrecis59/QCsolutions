using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;
using BIT;

namespace MultiUsos
{
    public class ClaseMultiusos
    {


        public Tuple<OdbcConnection, OdbcTransaction> ObtenerConexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=colchoneria");
            conectar.Open();
            OdbcTransaction transaction = conectar.BeginTransaction();
            return Tuple.Create(conectar, transaction);
        }

        OdbcTransaction transaction = null;                                             // Transaccion

        //  FUNCION QUE DEVUELVE LOS CODIGOS BASADOS EN CAMPOS DESCRIPCION
        public String ExtraerCodigo(string Codigo, string Tabla, string BusquedaPor, string Busqueda)// ENVIO DE PARAMETROS CON CODIGO, TABLA, EL CAMPO A BUSCAR Y LA BUSQUEDA
        {
            string datos = "";
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT " + Codigo + " FROM " + Tabla + " WHERE " + BusquedaPor + " = '" + Busqueda + "'";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos = (Reader[Codigo].ToString());
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

        // FUNCION QUE DEVUELVE UN DATASET PARA LLENAR UN DATAGIRD DE UNA TABLA QUE TENGA STATUS
        public DataSet LlenarGridWStatus(string CadenaDeCampos, string Tabla)   // ENVIO DE PARAMETROS, LOS CAMPOS A LLENAR Y LA TABLA A BUSCAR
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
                            cmd.CommandText = "SELECT " + CadenaDeCampos + " FROM " + Tabla + " WHERE status = 1";
                            OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            m_datos.Fill(ds);
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

        // FUNCION QUE DEVUELVE UN DATASET PARA LLENAR UN DATAGIRD DE UNA TABLA QUE TENGA STATUS
        public DataSet LlenarGridWhere(string CadenaDeCampos, string Tabla, string campoWhere, string DatoAbuscar)   // ENVIO DE PARAMETROS, LOS CAMPOS A LLENAR Y LA TABLA A BUSCAR
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
                            cmd.CommandText = "SELECT " + CadenaDeCampos + " FROM " + Tabla + " WHERE " + campoWhere + " = " + DatoAbuscar + ";";
                            OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            m_datos.Fill(ds);
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


        // FUNCION QUE DEVUELVE UN DATASET PARA LLENAR UN DATAGIRD DE UNA TABLA QUE TENGA STATUS
        public DataSet LlenarGridWhereLike(string CadenaDeCampos, string Tabla, string campoWhere, string DatoAbuscar)   // ENVIO DE PARAMETROS, LOS CAMPOS A LLENAR Y LA TABLA A BUSCAR
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
                            cmd.CommandText = "SELECT " + CadenaDeCampos + " FROM " + Tabla + " WHERE " + campoWhere + " LIKE '" + DatoAbuscar + "%';";
                            OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            m_datos.Fill(ds);
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


        // FUNCION QUE DEVUELVE UN DATASET PARA LLENAR UN DATAGIRD DE UNA TABLA QUE NO TENGA STATUS
        public DataSet LlenarGridWOStatus(string CadenaDeCampos, string Tabla)   // ENVIO DE PARAMETROS, LOS CAMPOS A LLENAR Y LA TABLA A BUSCAR
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
                            cmd.CommandText = "SELECT " + CadenaDeCampos + " FROM " + Tabla;
                            OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            m_datos.Fill(ds);
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

        // CARGAR COMBOBOX
        public void cargarDatosACombobox(ComboBox cboEnviado, string DatoALlenar,string Tabla)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT " + DatoALlenar + " FROM " + Tabla + " ; ";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                cboEnviado.Items.Add(Reader[DatoALlenar].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
                cboEnviado.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }



        //  FUNCION QUE DEVUELVE LOS CODIGOS FINALES AUMENTADOS
        /// <summary>
        /// Este metodo genera codigos mayores a lo contenidos en la base de datos
        /// </summary>
        /// <param name="CampoCodigo">Campo de la tabla de la que se va a buscar</param>
        /// <param name="Tabla">Tabla donde se encuetra el campo</param>
        /// <returns></returns>
        public string GenerarAutoCodigo(string CampoCodigo, string Tabla)// ENVIO DE PARAMETROS CON CODIGO, TABLA
        { 
            string datos = "";
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT MAX(" + CampoCodigo + ") " + CampoCodigo + " FROM " + Tabla + ";";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos = (Reader[CampoCodigo].ToString());
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
            string datosf = "0";
            datosf = (System.Convert.ToInt32(datos) + 1).ToString();
            return datosf;
        }



        public void InsertarDatosAplicaciones(string Tabla, string DatosAInsertar)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO " + Tabla + " VALUES(" + DatosAInsertar + ");";
                            cmd.ExecuteNonQuery();
                            //MessageBox.Show("Insertado Exitosamente");
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public bool ValidarExistenciaDeCodigos(string Tabla,string CampoABuscar, string DatoABuscar)
        {
            bool res = false;
            string datos = "";
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT "+CampoABuscar+" FROM "+Tabla+" WHERE "+CampoABuscar+" = "+ DatoABuscar+";";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos = (Reader[CampoABuscar].ToString());
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
           // MessageBox.Show("--" + datos + "--");
            if(datos == "")
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }

        // MODIFICAR DATOS
        public void ModificarDatos(string Tabla, string DatosACambiar, string CampoABuscar, string DatoABuscar)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "UPDATE " + Tabla + " SET " + DatosACambiar + " WHERE " + CampoABuscar + "=" + DatoABuscar + ";";
                            cmd.ExecuteNonQuery();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        // ELIMINAR DATOS
        public void EliminarDatos(string Tabla, string CampoABuscar, string DatoABuscar)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "DELETE FROM " + Tabla + " WHERE " + CampoABuscar + "=" + DatoABuscar + ";";
                            cmd.ExecuteNonQuery();
                            //MessageBox.Show("Modificado");
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string gg()
        {
            return "aa";
        }

        public string DevolverSentencia_Insert(string Tabla, string DatosAInsertar)
        {
            string command = "";
            try
            {
                command = "INSERT INTO " + Tabla + " VALUES(" + DatosAInsertar + ");";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return command;
        }


        public string DevolverSentencia_Modificar(string Tabla, string DatosACambiar, string CampoABuscar, string DatoABuscar)
        {
            string command = "";
            try
            {
                command = "UPDATE " + Tabla + " SET " + DatosACambiar + " WHERE " + CampoABuscar + "=" + DatoABuscar + ";";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return command;
        }


        public string DevolverSentencia_Eliminar(string Tabla, string CampoABuscar, string DatoABuscar)
        {
            string command = "";
            try
            {
                command = "DELETE FROM " + Tabla + " WHERE " + CampoABuscar + "=" + DatoABuscar + ";";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return command;
        }

        public void EjectuarOperacionExterna(List<string> sParametro, string accionBitacora, string appCod)
        {
            try
            {
                graphicLayer cp = new graphicLayer();
                var resultado = ObtenerConexion();
                OdbcTransaction transaction = resultado.Item2;
                OdbcCommand cmd = resultado.Item1.CreateCommand();
                cmd.Transaction = transaction;

                foreach (string value in sParametro)
                {
                    cmd.CommandText = value;
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
                cp.Accion(accionBitacora, appCod);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar esta accíon " + ex);
                try
                {
                    transaction.Rollback();
                    Console.WriteLine("Se realizo Rollback");
                }
                catch (Exception)
                {
                    Console.WriteLine("No se pudo realizar Rollback");
                }
            }
        }

    }
}
