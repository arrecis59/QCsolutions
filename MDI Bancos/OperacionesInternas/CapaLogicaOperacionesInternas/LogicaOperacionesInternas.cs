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

        public int getCuentaId(string name)
        {
            return dt.getCuentaId(name);
        }

        public int getTipoTransferenciaId(string name)
        {
            return dt.getTipoTransferenciaId(name);
        }

        public bool verificaFondos(int cuentaId, int monto)
        {
            return dt.verificaFondos(cuentaId, monto);
        }

        public int obtenerSaldoCuenta(int cuentaId)
        {
            return dt.obtenerSaldoCuenta(cuentaId);
        }

        public bool ajusteCuentas(int cuentaOrigenId, int cuentaDestinoId, int monto)
        {
            return dt.ajusteCuentas(cuentaOrigenId, cuentaDestinoId, monto);
        }

        public bool realizarTransferencia(int cuentaOrigenId, int cuentaDestinoId, int tipoTransferenciaId, string fecha, string empleado, string tipoMovimiento, string nota, int importe)
        {
            return dt.realizarTransferencia(cuentaOrigenId, cuentaDestinoId, tipoTransferenciaId, empleado, fecha, tipoMovimiento, nota, importe);
        }

        public int getEmpleadoId(string name)
        {
            return dt.getEmpleadoId(name);
        }



    }
}
