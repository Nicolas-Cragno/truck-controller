﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Persona
    {
        public int Nro_Dni {  get; set; }
        public string Apellido { get; set; }
        public string Nombres { get; set; }
        public Tractor Tractor_Asignado { get; set; }
        

    }
}
