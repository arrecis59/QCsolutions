using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaDatosOpciones
{
    public class CapaDatos_Opciones
    {
        public List<Colores> obtenerColores()
        {
            ConexionBDOpciones cone = new ConexionBDOpciones();
            List<Colores> respuesta = new List<Colores>();
            string query = "SELECT id_Color, nombreColor, fondo, barraDeTitulo, barraDeMenu, barraDeEstado, barraDeTituloAplicaciones, fondoAplicaciones, fuenteDeTexto1, fuenteDeTexto2, fuenteDeTexto3, utilizado FROM tbl_colores;";
            try
            {
                using (var conn = new OdbcConnection(cone.nombreDns())) 
                {
                    OdbcDataReader reader;
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        reader = cmd.ExecuteReader();
                        List<Colores> listaColores = new List<Colores>();
                        while (reader.Read())
                        {
                            Colores colores = new Colores();
                            colores.ID = Convert.ToInt32(reader["id_Color"]);
                            colores.Nombre = Convert.ToString(reader["nombreColor"]);
                            colores.Fondo = Convert.ToString(reader["fondo"]);
                            colores.BarraDeTitulo = Convert.ToString(reader["barraDeTitulo"]);
                            colores.BarraDeMenu = Convert.ToString(reader["barraDeMenu"]);
                            colores.BarraDeEstado = Convert.ToString(reader["barraDeEstado"]);
                            colores.BarraDeTituloAplicaciones = Convert.ToString(reader["barraDeTituloAplicaciones"]);
                            colores.FondoAplicaciones = Convert.ToString(reader["fondoAplicaciones"]);
                            colores.FunteDeTexto1 = Convert.ToString(reader["fuenteDeTexto1"]);
                            colores.FunteDeTexto2 = Convert.ToString(reader["fuenteDeTexto2"]);
                            colores.FunteDeTexto3 = Convert.ToString(reader["fuenteDeTexto3"]);
                            colores.utilizado = Convert.ToInt32(reader["utilizado"]);
                            listaColores.Add(colores);
                        }
                        conn.Close();
                        respuesta = listaColores;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error generado por la base de datos: " + exception.ToString());
            }
            return respuesta;
        }
    }
}
