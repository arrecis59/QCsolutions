using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatosCreacionDeCuentas;

namespace CapaLogicaCreacionDeCuentas
{
    public class ClaseCapaLogicaCreacionDeCuentas
    {
        public string[] retornoDatosCuentas(string codigo)
        {
            string[] datos;
            datos = new string[9];
            ClaseCapaDatosCreacionDeCuentas cd = new ClaseCapaDatosCreacionDeCuentas();
            datos = cd.cargarDatosATextboxCuentas(codigo);
            return datos;
        }

        // Retorno de datos del cliente
        public string[] retornoDatosCliente(string codigo)
        {
            string[] datos;
            datos = new string[10];
            ClaseCapaDatosCreacionDeCuentas cd = new ClaseCapaDatosCreacionDeCuentas();
            datos = cd.cargarDatosATextboxClientes(codigo);
            return datos;
        }
    }
}
