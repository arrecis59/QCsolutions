using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procesoGestion
{
    class MotivoGestion
    {
        public int idMotivoGestion { get; set; }
        public String nombre { get; set; }
        public int tipoEmpleado { get; set; }
        public String descripcion { get; set; }

        public override string ToString()
        {
            String[] tmp = new string[4];
            tmp[0] = this.idMotivoGestion.ToString();
            tmp[1] = this.nombre;
            tmp[2] = this.tipoEmpleado.ToString();
            tmp[3] = this.descripcion;

            return " " + tmp[0] + ", " + tmp[1] + ", " + tmp[2] + ", " + tmp[3] + " ";
        }

        public string cadenaValor()
        {
            String[] tmp = new string[4];
            tmp[0] = this.idMotivoGestion.ToString();
            tmp[1] = this.nombre;
            tmp[2] = this.tipoEmpleado.ToString();
            tmp[3] = this.descripcion;

            return " " + tmp[0] + ", '" + tmp[1] + "', " + tmp[2] + ", '" + tmp[3] + "' ";
        }

    }
}
