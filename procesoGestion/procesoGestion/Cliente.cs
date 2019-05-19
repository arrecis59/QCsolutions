using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procesoGestion
{
    class Cliente
    {
        public int idcliente { get; set; }
        public String DPI { get; set; }
        public String nombre { get; set; }
        public String apellido1 { get; set; }
        public String apellido2 { get; set; }
        public String telefono { get; set; }
        public String celular { get; set; }
        public String correo { get; set; }
        public DateTime fecha_nac { get; set; }
        public String genero { get; set; }
        public String nit { get; set; }
                
        public String getNombreCompleto()
        {
            return this.nombre + " " + this.apellido1 + " " + this.apellido2;
        }

        public override string ToString()
        {
            String[] tmp = new string[11];
            tmp[0] = Convert.ToString(this.idcliente);
            tmp[1] = this.DPI;
            tmp[2] = this.nombre;
            tmp[3] = this.apellido1;
            tmp[4] = this.apellido2;
            tmp[5] = this.telefono;
            tmp[6] = this.celular;
            tmp[7] = this.correo;
            tmp[8] = this.fecha_nac.ToShortDateString();
            tmp[9] = this.genero;
            tmp[10] = this.nit;

            return " " + tmp[0] + ", " + tmp[1] + ", " + tmp[2] + ", " + tmp[3] + ", " + tmp[4] + ", " + tmp[5] + ", " + tmp[6] +
                ", " + tmp[7] + ", " + tmp[8] + ", " + tmp[9] + ", " + tmp[10] + " ";
        }
    }
}
