using System;
using System.Data.Odbc;

namespace CapaDatosGestion
{
    class ConexionGestion
    {
        public Tuple<OdbcConnection, OdbcTransaction> crearConexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dns=colchoneria");
            conectar.Open();
            OdbcTransaction transaccion = conectar.BeginTransaction();

            return Tuple.Create(conectar, transaccion);
        }
    }
}
