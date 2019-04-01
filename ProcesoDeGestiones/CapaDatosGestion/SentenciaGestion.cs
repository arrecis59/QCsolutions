using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CapaDatosGestion
{
    class SentenciaGestion
    {

        public void crearGestion(string codigo, string observacion, string prioridad,string idEmpleado, string cuenta)
        {
            try
            {
                string query = null;
                if (cuenta != null && "".Equals(cuenta.Trim())) { 
                    query = "INSERT INTO tbl_gestion (id_gestion, observaciones, nivel_Prioridad, estado_gestion, tbl_empleado_id_empleado, tbl_cuenta_id_cuenta)" +
                        "VALUES ('"+ codigo +"', '"+ observacion +"', '"+ prioridad + "', 'PENDIENTE', '" + idEmpleado +"', '"+ cuenta +"');";
                }
                else
                {
                    query = "INSERT INTO tbl_gestion (id_gestion, observaciones, nivel_Prioridad, estado_gestion, tbl_empleado_id_empleado)" +
                        "VALUES ('"+ codigo +"', '"+ observacion +"', '"+ prioridad +"', 'PENDIENTE', '"+ idEmpleado +"');";
                }

                CapaDatosGestion capaDatos = new CapaDatosGestion();
                capaDatos.ejecutarGestion(query);
                MessageBox.Show("Ingreso de datos exitoso");
                Console.WriteLine("Ingreso exitoso");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine("Error al realizar esta accíon " + e);
            }
        }

        public void respuestaGestion(string codigo, string estado,string idEmpleado)
        {
            try
            {
                string query = null;

                query = "UPDATE tbl_gestion "+
                    "SET ESTADO = '"+ estado + "', tbl_empleado_id_empleado = '"+ idEmpleado +"' "+
                    "WHERE id_gestion = '"+ codigo +"';";

                CapaDatosGestion capaDatos = new CapaDatosGestion();
                capaDatos.ejecutarGestion(query);
                MessageBox.Show("Ingreso de datos exitoso");
                Console.WriteLine("Ingreso exitoso");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine("Error al realizar esta accíon " + e);
            }
        }

        public DataSet consultaGestionPorCodigo(string codigo)
        {
            DataSet dataSet = null;

            try
            {
                string query = "SELECT g.id_gestion, g.observaciones, g.nivel_Prioridad, g.estado_gestion, (e.nombre||' '||e.apellido_1||' '||e.apellido_2) AS empleado, g.cuenta "+
                    "FROM tbl_empleado e, tbl_gestion g "+
                    "WHERE e.id_empleado = g.tbl_empleado_id_empleado "+
                    "AND g.id_gestion = '" + codigo + "';";

                CapaDatosGestion capaDatos = new CapaDatosGestion();
                dataSet = capaDatos.llenarDataGridGestion(query);

                return dataSet;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en operacion " + e.ToString());
                Console.WriteLine("Error en operacion " + e);
            }

            return null;
        }
    }
}
