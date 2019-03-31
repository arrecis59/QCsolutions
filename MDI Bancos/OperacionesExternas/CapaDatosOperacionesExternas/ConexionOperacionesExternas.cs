using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaDatosOperacionesExternas
{
    public class ConexionOperacionesExternas
    {
        public Tuple<OdbcConnection, OdbcTransaction> ObtenerConexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=colchoneria");
            conectar.Open();
            OdbcTransaction transaction = conectar.BeginTransaction();
            return Tuple.Create(conectar, transaction);
        }
    }
}
