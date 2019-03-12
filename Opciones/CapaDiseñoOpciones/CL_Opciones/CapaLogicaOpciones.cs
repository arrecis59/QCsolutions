using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatosOpciones;

namespace CL_Opciones
{
    public class CapaLogicaOpciones
    {
        public Colores obtenerColores()
        {
            CapaDatos_Opciones capaDatos = new CapaDatos_Opciones();
            List<Colores> colores = capaDatos.obtenerColores();
            foreach (Colores col in colores)
            {
                if (col.utilizado == 1)
                {
                    return col;
                }
            }
            return null;
        }
    }
}
