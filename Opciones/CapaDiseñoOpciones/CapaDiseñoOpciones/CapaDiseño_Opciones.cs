using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatosOpciones;
using CL_Opciones;

namespace CapaDiseñoOpciones
{
    public class CapaDiseño_Opciones
    {
        public Colores obtenerColores()
        {
            CapaLogicaOpciones cl = new CapaLogicaOpciones();
            Colores col = cl.obtenerColores();
            return col;
        }
    }
}
