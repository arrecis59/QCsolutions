using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatosPagoAOrganizaciones;

namespace CapaLogicaPagoAOrganizaciones
{
    public class LogicaPagoAOrganizaciones
    {
        public string[] cargarTxt_1(string codigo)
        {
            string[] datos;
            datos = new string[5];
            DatosPagoAOrganizaciones cd = new DatosPagoAOrganizaciones();
            datos = cd.cargarDatosATextbox_1(codigo);
            return datos;
        }


        public string calculoDeNuevoSaldo_1(string importe, string saldo)
        {
            int newSaldo = Convert.ToInt32(saldo) - Convert.ToInt32(importe);
            return newSaldo.ToString();
        }

        public string calculoDeNuevoSaldo_2(string importe, string saldo)
        {
            int newSaldo = Convert.ToInt32(saldo) + Convert.ToInt32(importe);
            return newSaldo.ToString();
        }
    }
}
