using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Evento
    {
        public int Id {  get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string Detalle { get; set; }
        
        public int DNI_Persona { get; set; }
        public int Nro_Interno { get; set; }

        // public Persona Persona { get; set; }
        // public Tractor Tractor { get; set; }
    }
}
