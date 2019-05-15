using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatosOperacionesInternas;
using System.Data;

namespace CapaLogicaOperacionesInternas
{
    public class LogicaRetiros
    {
        CapaDatosOperacionesInternas.DatosRetiros dt = new CapaDatosOperacionesInternas.DatosRetiros();
        

        public DataSet getCuentas()
        {
            return dt.getCuentas();
        }

        public int getCuentaId(string name)
        {
            return dt.getCuentaId(name);
        }

        public bool verificaFondos(int cuentaId, int monto)
        {
            return dt.verificaFondos(cuentaId, monto);
        }

        public bool ajusteCuentas(int cuentaID, int monto)
        {
            return dt.ajusteCuentas(cuentaID, monto);
        }

        public bool registrarMovimiento(string tipoMovimiento, int importe, string fecha, int cuentaId, int tipoPagoId)
        {
            return dt.registrarMovimiento(tipoMovimiento, importe, fecha, cuentaId, tipoPagoId);
        }
    }
}
