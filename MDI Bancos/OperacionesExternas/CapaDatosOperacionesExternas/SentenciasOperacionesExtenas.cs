using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CapaDatosOperacionesExternas
{
    public class SentenciasOperacionesExtenas
    {
        
        public void SenInsertar(string tabla, string codigo, string fecha, string importe, string nota, string cuenta, string benExterno, string agencia, string empleado,string estado, string status)
        {
            try
            {
                string Parametro = "INSERT INTO " + tabla + " VALUES ('" + codigo + "', '" + fecha + "', '" + importe + "', '" + nota + "', '" + cuenta + "', '" + benExterno + "', '" + agencia + "', '" + empleado + "', '" + estado + "', '" + status + "');";
                CapaDatosOperacionesExternas cpd = new CapaDatosOperacionesExternas();
                cpd.EjectuarOperacionExterna(Parametro);
                MessageBox.Show("Ingreso de datos exitoso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SenInsertarSolicitud(string tabla, string fecha, string estado, string transferenciaExterna)
        {
            try
            {
                string Parametro = "INSERT INTO " + tabla + " VALUES (0, '" + fecha + "', '" + estado + "', '" + transferenciaExterna + "');";
                CapaDatosOperacionesExternas cpd = new CapaDatosOperacionesExternas();
                cpd.EjectuarOperacionExterna(Parametro);
                //MessageBox.Show("Ingreso de datos exitoso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataSet SenCargarDatosOperacionesExternas(string tabla)
        {
            DataSet ds;
            try
            {
                string Parametro = "SELECT * FROM "+tabla+";";
                CapaDatosOperacionesExternas cpd = new CapaDatosOperacionesExternas();
                ds = cpd.LLenarDataGridOpeexterna(Parametro);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }

        public DataSet SenCargarDatosOpercionesExternasBusqueda(string datoABuscar, int opcionABuscar)
        {
            DataSet ds;
            string Parametro = "";
            if(opcionABuscar == 1)
            {
                Parametro = "SELECT * FROM tbl_transferencia_externa WHERE id_transferencia_externa LIKE '"+datoABuscar+"%' ;";
            }
            else if(opcionABuscar == 2){
                Parametro = "SELECT * FROM tbl_transferencia_externa WHERE tbl_cuenta_id_cuenta LIKE '" + datoABuscar + "%' ;";
            }
            else if (opcionABuscar == 3)
            {
                Parametro = "SELECT * FROM tbl_transferencia_externa WHERE tbl_beneficiario_externo_id_beneficiario_externo LIKE '" + datoABuscar + "%' ;";
            }
            else if (opcionABuscar == 4)
            {
                Parametro = "SELECT * FROM tbl_transferencia_externa WHERE tbl_agencia_id_agencia LIKE '" + datoABuscar + "%' ;";
            }
            try
            {
                CapaDatosOperacionesExternas cpd = new CapaDatosOperacionesExternas();
                ds = cpd.LLenarDataGridOpeexterna(Parametro);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }

    }
}
