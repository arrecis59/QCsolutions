using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaDatosGestion
{
    public class CapaDatosGestion
    {
        ConexionGestion conexion = new ConexionGestion();
        OdbcTransaction transaccion = null;

        public void ejecutarGestion(string comando)
        {
            try
            {
                Tuple<OdbcConnection, OdbcTransaction> tuple = this.conexion.crearConexion();
                OdbcCommand cmd = tuple.Item1.CreateCommand();
                this.transaccion = tuple.Item2;
                cmd.Transaction = this.transaccion;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();

                this.transaccion.Commit();
            } catch (Exception e)
            {
                MessageBox.Show("Error al realizar esta accíon " + e);
                Console.WriteLine("Error al realizar esta accíon " + e);
                try
                {
                    this.transaccion.Rollback();
                    Console.WriteLine("Se realizo Rollback");
                }
                catch (Exception)
                {
                    Console.WriteLine("no se pudo realizar Rollback");
                }
            }
        }

        public DataSet llenarDataGridGestion(string comando)
        {
            DataSet dataSet = new DataSet();
            try
            {
                Tuple<OdbcConnection, OdbcTransaction> tuple = conexion.crearConexion();
                OdbcCommand cmd = tuple.Item1.CreateCommand();
                this.transaccion = tuple.Item2;
                cmd.Transaction = this.transaccion;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();

                OdbcDataAdapter odbcDataAdapter = new OdbcDataAdapter(cmd);
                odbcDataAdapter.Fill(dataSet);

                this.transaccion.Commit();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al realizar esta accíon " + e);
                Console.WriteLine("Error al realizar esta accíon " + e);
                try
                {
                    this.transaccion.Rollback();
                    Console.WriteLine("Se realizo Rollback");
                }
                catch (Exception)
                {
                    Console.WriteLine("no se pudo realizar Rollback");
                }
            }

            return dataSet;
        }
    }
}
