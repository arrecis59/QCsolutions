using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procesoGestion
{
    class EstadoGestion
    {
        public int idEstadoGestion { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }

        public override string ToString()
        {
            String[] tmp = new string[3];
            tmp[0] = this.idEstadoGestion.ToString();
            tmp[1] = this.nombre;
            tmp[2] = this.descripcion;

            return " " + tmp[0] + ", " + tmp[1] + ", "+ tmp[2] + " ";
        }

        public string cadenaValor()
        {
            String[] tmp = new string[3];
            tmp[0] = this.idEstadoGestion.ToString();
            tmp[1] = this.nombre;
            tmp[2] = this.descripcion;

            return " " + tmp[0] + ", '" + tmp[1] + "', '" + tmp[2] + "' ";
        }

    }
}
