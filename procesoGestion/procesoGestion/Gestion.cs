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
        public int prioridad { get; set; }

        public override string ToString()
        {
            String[] tmp = new string[10];
            tmp[0] = this.idGestion.ToString();
            tmp[1] = this.fecha_gestion.ToShortDateString();
            tmp[2] = this.fecha_solucion.ToShortDateString();
            tmp[3] = this.descripcion;
            tmp[4] = this.empl_servicio.idEmpleado.ToString();
            tmp[5] = this.empl_solucion.idEmpleado.ToString();
            tmp[6] = this.cliente.idcliente.ToString();
            tmp[7] = this.motivo.idMotivoGestion.ToString();
            tmp[8] = this.estado.idEstadoGestion.ToString();
            tmp[9] = this.prioridad.ToString();
            return " "+ tmp[0] +", " + tmp[1] + ", " + tmp[2] + ", " + tmp[3] + ", " + tmp[4] + ", " + tmp[5] + ", " + tmp[6] + ", " +
                tmp[7] + ", " + tmp[8] + ", " + tmp[9] + " ";
        }

        public string cadenaValor()
        {
            String[] tmp = new string[10];
            tmp[0] = this.idGestion.ToString();
            tmp[1] = this.fecha_gestion.ToShortDateString();
            tmp[2] = this.fecha_solucion.ToShortDateString();
            tmp[3] = this.estado.idEstadoGestion.ToString();
            tmp[4] = this.prioridad.ToString();
            tmp[5] = this.motivo.idMotivoGestion.ToString();
            tmp[6] = this.descripcion;
            tmp[7] = this.empl_servicio.idEmpleado.ToString();
            tmp[8] = this.empl_solucion.idEmpleado.ToString();
            tmp[9] = this.cliente.idcliente.ToString();
            return " " + tmp[0] + ", STR_TO_DATE('" + tmp[1] + "','%d/%m/%Y'), STR_TO_DATE('" + tmp[2] + "','%d/%m/%Y'), '" + tmp[3] +
                "', " + tmp[4] + ", " + tmp[5] + ", '" + tmp[6] + "', " + tmp[7] + ", " + tmp[8] + ", " + tmp[9] + " ";
        }

        public string getSeguimiento()
        {
            String[] tmp = new string[6];
            tmp[0] = this.fecha_solucion.ToShortDateString();
            tmp[1] = this.estado.idEstadoGestion.ToString();
            tmp[2] = this.prioridad.ToString();
            tmp[3] = this.motivo.idMotivoGestion.ToString();
            tmp[4] = this.descripcion;
            tmp[5] = this.empl_solucion.idEmpleado.ToString();
            return " STR_TO_DATE('" + tmp[0] + "','%d/%m/%Y'), " + tmp[1] + ", " + tmp[2] +
                ", " + tmp[3] + ", " + tmp[4] + ", " + tmp[5] + " ";
        }
            
    }
}