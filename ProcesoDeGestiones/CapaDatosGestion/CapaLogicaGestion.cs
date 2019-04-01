using System;
using System.Data;
using System.Windows.Forms;
using CapaDatosGestion;

namespace CapaLogicaGestion
{
    public class CapaLogicaGestion 
    {
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

        public bool validarCreacionGestion(string codigo, string observacion, string prioridad, string idEmpleado)
        {
            string mensajeError = "Son necesarios el (los) campo (s) ";
            bool error = true;

            if (codigo == null || "".Equals(codigo))
            {
                mensajeError = mensajeError + "Codigo";
                error = false;
            }

            if (observacion == null || "".Equals(observacion))
            {
                mensajeError = mensajeError + ", Observaciones";
                error = false;
            }

            if (prioridad == null || "".Equals(prioridad))
            {
                mensajeError = mensajeError + ", Prioridad";
                error = false;
            }

            if (idEmpleado == null || "".Equals(idEmpleado))
            {
                mensajeError = mensajeError + ", Empleado";
                error = false;
            }

            if (!error)
            {
                MessageBox.Show(mensajeError +".");
                Console.WriteLine(mensajeError + ".");
            }

            return error;
        }

        public DataSet obtenerGestionPorCodigo(string codigo)
        {
            DataSet dataSet = null;

            if(codigo != null || "".Equals(codigo))
            {
                dataSet = new SentenciaGestion().consultaGestionPorCodigo(codigo);
            }

            return dataSet;
        }
    }
}
