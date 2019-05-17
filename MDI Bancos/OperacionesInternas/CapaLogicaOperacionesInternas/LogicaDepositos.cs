using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatosOperacionesInternas;
using System.Data;

namespace CapaLogicaOperacionesInternas
{
    public class LogicaDepositos
    {

        CapaDatosOperacionesInternas.DatosDepositos dt = new CapaDatosOperacionesInternas.DatosDepositos();

        public DataSet getCuentas()
        {
            return dt.getCuentas();
        }

        public DataSet getEmpleados()
        {
            return dt.getEmpleados();
        }

        public DataSet getTipoPago()
        {
            return dt.getTipoPago();
        }

        public int getTipoPagoId(string name)
        {
            return dt.getTipoPagoId(name);
        }

        public int getCuentaId(string name)
        {
            return dt.getCuentaId(name);
        }

        public int getEmpleadoId(string name)
        {
            return dt.getEmpleadoId(name);
        }

        public bool registrarMovimiento(string tipoMovimiento, int importe, string fecha, int cuentaId, int tipoPagoId)
        {
            return dt.registrarMovimiento(tipoMovimiento, importe, fecha, cuentaId, tipoPagoId);
        }

        public bool ajusteCuentas(int cuentaID, int monto)
        {
            return dt.ajusteCuentas(cuentaID, monto);
        }

    }
}
