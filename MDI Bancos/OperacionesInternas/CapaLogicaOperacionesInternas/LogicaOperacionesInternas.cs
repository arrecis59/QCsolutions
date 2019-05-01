using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatosOperacionesInternas;

namespace CapaLogicaOperacionesInternas
{
    public class LogicaOperacionesInternas
    {
        DatosOperacionesInternas dt = new DatosOperacionesInternas();


        public DataSet getEmpleados()
        {
            return dt.getEmpleados();
        }

        public DataSet getCuentas()
        {
            return dt.getCuentas();
        }

        public DataSet getTipoTransferencia()
        {
            return dt.getTipoTransferencia();
        }

    }
}
