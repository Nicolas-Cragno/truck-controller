using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Tractor
    {
        public int Nro_Interno { get; set; }
        public string Patente { get; set; }
        public string Seguimiento_Satelital { get; set; }
        //public string Combustible_Satelital { get; set; }
        public Persona Chofer_Asignado { get; set; }
    }
}
