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
    }
}
