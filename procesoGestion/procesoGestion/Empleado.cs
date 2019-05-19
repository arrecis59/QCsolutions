using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procesoGestion
{
    class Empleado
    {
        public int idEmpleado { get; set; }
        public String nombre { get; set; }
        public String apellido1 { get; set; }
        public String apellido2 { get; set; }
        public String correo { get; set; }
        public int tipo_empleado { get; set; }

        public String getNombre()
        {
            return this.nombre + " " + this.apellido1 + " " + this.apellido2;
        }
    }
}
