using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace OperacionesInternas
{
    public class Class1
    {
        private OdbcConnection cn = new OdbcConnection("dsn=colchoneria");

        public OdbcConnection Conectar()
        {
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return null;
        }

        public OdbcConnection Desconectar()
        {
            try
            {
                cn.Close();
                return cn;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return null;
        }
    }
}
