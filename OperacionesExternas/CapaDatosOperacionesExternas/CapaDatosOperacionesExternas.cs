using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;

namespace CapaDatosOperacionesExternas
{
    public class CapaDatosOperacionesExternas
    {

        ConexionOperacionesExternas nuevo = new ConexionOperacionesExternas();
        OdbcTransaction transaction = null;

        public DataSet LLenarDataGridOpeexterna(string sParametro)
        {
            DataSet ds = new DataSet();
            try
            {
                var resultado = nuevo.ObtenerConexion();
                OdbcTransaction transaction = resultado.Item2;
                OdbcCommand cmd = resultado.Item1.CreateCommand();
                cmd.Transaction = transaction;

                cmd.CommandText = sParametro;
                cmd.ExecuteNonQuery();
                OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                ds = new DataSet();
                m_datos.Fill(ds);

                transaction.Commit();
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
                    Console.WriteLine("no se pudo realizar Rollback");
                }
            }
            return ds;
        }

    }
}
