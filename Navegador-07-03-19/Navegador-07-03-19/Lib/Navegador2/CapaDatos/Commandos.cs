﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Commandos
    {
        Conexion nuevo = new Conexion();
        Conexion nuevo2 = new Conexion();
        Conexion nuevo3 = new Conexion();
        Conexion nuevo4 = new Conexion();
        Conexion nuevo5 = new Conexion();
        Conexion nuevo6 = new Conexion();
        Conexion nuevo7 = new Conexion();
        OdbcTransaction transaction = null;


        /***************************************************/
        

        public bool getTFREporteAplicacion(string appCodigo)    // Funcion que devuelve si existe un reporte para la aplicacion
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
                            cmd.CommandText = "SELECT PK_Id_Documento FROM tbl_doc_asociado WHERE FK_Api_codigo = '" + appCodigo + "' AND status = 1;";
                            //cmd.CommandText = "SELECT PK_Modulo_codigo FROM tbl_modulo WHERE modulo_nombre = '" + nombremodulo + "'";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                return true;
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
                return false;
            }
            return false;
        }
        /***************************************************/

        public void pubInsertData(string sParametro)
        {
            try
            {
                var resultado = nuevo.ObtenerConexion();
                OdbcTransaction transaction = resultado.Item2;
                OdbcCommand cmd = resultado.Item1.CreateCommand();
                cmd.Transaction = transaction;

                cmd.CommandText = sParametro;
                cmd.ExecuteNonQuery();

                transaction.Commit();
            } catch (Exception ex)
            {
                MessageBox.Show("Error al realizar esta accíon " + ex);
                try
                {
                    transaction.Rollback();
                    Console.WriteLine("Se realizo Rollback");
                }
                catch (Exception)
                {
                    Console.WriteLine("no se pudo realizar Rollback");
                }
            }
        }

        public DataTable pubSeleccionarData(string sParametro)
        {
            var resultado = nuevo2.ObtenerConexion();
            OdbcTransaction transaction = resultado.Item2;
            OdbcCommand comando = new OdbcCommand(sParametro, resultado.Item1);
            comando.Transaction = transaction;
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            try
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error, tabla inexistente");
                return null;
            }
        }


        //Retorna Id del registro seleccionado

        public int selectedItemCombo(string Nid, string table, string campo, string search)
        {

            OdbcDataReader dr = null;
            int id = 0;
            string ssearch = "\'" + search + "\'";
            string sParametro = "SELECT " + Nid + " FROM " + table + " WHERE " + campo + " = " + ssearch + "";

            var resultado = nuevo6.ObtenerConexion();
            OdbcTransaction transaction = resultado.Item2;
            OdbcCommand comando = new OdbcCommand(sParametro, resultado.Item1);
            comando.Transaction = transaction;

            try
            {
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    id = dr.GetInt32(0);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Error al obtener el Id del elemento seleccionado en combobox");
            }


            return id;
        }



        public DataTable pubSeleccionarCampos(string sParametro)
        {
            var resultado = nuevo3.ObtenerConexion();
            OdbcTransaction transaction = resultado.Item2;
            OdbcCommand comando = new OdbcCommand(sParametro, resultado.Item1);
            comando.Transaction = transaction;
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            try
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error, Campos inexistentes");
                return null;
            }
        }

        public DataSet pubObtenerDatos(string sParametro, string campo)
        {
            var resultado = nuevo4.ObtenerConexion();
            OdbcTransaction transaction = resultado.Item2;
            OdbcCommand comando = new OdbcCommand(sParametro, resultado.Item1);
            comando.Transaction = transaction;
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            try
            {
                DataSet tabla = new DataSet();
                adaptador.Fill(tabla, campo);
                return tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error, Campos inexistentes para combobox");
                return null;
            }
        }

        public void insertarDatagrid(string tablaData, string[] camposTabla3, DataGridView dgrData, int[] columnas)
        {
            for (int fila = 0; fila < dgrData.Rows.Count - 1; fila++)
            {
                string sParametro = "INSERT INTO " + tablaData + " (";
                for (int i = 0; i < camposTabla3.Length; i++)
                {
                    sParametro = sParametro + camposTabla3[i] + ", ";
                }
                char[] quitar = { ',', ' ' };
                sParametro = sParametro.TrimEnd(quitar);
                sParametro = sParametro + ") VALUES (";

                for (int col = 0; col < columnas.Length; col++)
                {
                    string valor = dgrData.Rows[fila].Cells[columnas[col]].Value.ToString();
                    sParametro = sParametro + "'" + valor + "'" + ",";
                }
                char[] quitar2 = { ',' };
                sParametro = sParametro.TrimEnd(quitar2);
                sParametro = sParametro + ");";
                Console.WriteLine(sParametro);
                pubInsertData(sParametro);
            }
            dgrData.Rows.Clear();
        }
    }
}
