using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatosOperacionesExternas;
using System.Data.Odbc;
using System.Data;

namespace CapaLogicaOperacionesExternas
{
    public class LogicaOperacionesExternas
    {
        SentenciasOperacionesExtenas cpds = new SentenciasOperacionesExtenas();

        public void validarNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void validacionInsertarOperacioensExternas(string tabla, string codigo, string fecha, string importe, string nota, string cuenta, string benExterno, string agencia, string empleado, string estado, string status)
        {
            if(codigo != "" || fecha != "" || importe != "" || nota != "" || cuenta != "" || benExterno != "" || agencia != "" || empleado != "" || estado != "" || status != "")
            {
                cpds.SenInsertar(tabla, codigo, fecha, importe, nota, cuenta, benExterno, agencia, empleado, estado, status);
                cpds.SenInsertarSolicitud("tbl_solicitud_conciliacion" , fecha, "Pendiente", codigo);
            }
            else
            {
                MessageBox.Show("Por favor introduce todos los campos");
            }
        }

        public DataSet CargarDataGridOperacionesExternas(string datoABuscar, int opcion)
        {
            DataSet ds_OpeExternas;
            if(datoABuscar == "")
            {
                ds_OpeExternas = cpds.SenCargarDatosOperacionesExternas("tbl_transferencia_externa");
            }
            else
            {
                ds_OpeExternas =  cpds.SenCargarDatosOpercionesExternasBusqueda(datoABuscar, opcion);
            }
            return ds_OpeExternas;
        }

        public DataSet CargarDataGridSolicitudesOpeExternas()
        {
            DataSet ds_SolicitudesOpeExternas;
            ds_SolicitudesOpeExternas = cpds.SenCargarDatosOperacionesExternas("tbl_solicitud_conciliacion");
            return ds_SolicitudesOpeExternas;
        }


        public string calculoDeNuevoSaldo(string importe, string saldo)
        {
            int newSaldo = Convert.ToInt32(saldo) - Convert.ToInt32(importe);
            return newSaldo.ToString();
        }

    }
}
