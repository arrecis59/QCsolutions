using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace procesoGestion
{
    class Gestion
    {
        public int idGestion { get; set; }
        public DateTime fecha_gestion { get; set; }
        public DateTime fecha_solucion { get; set; }
        public String descripcion { get; set; }
        public Empleado empl_servicio { get; set; }
        public Empleado empl_solucion { get; set; }
        public Cliente cliente { get; set; }
        public MotivoGestion motivo { get; set; }
        public EstadoGestion estado { get; set; }
        
    }
}