﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaHospital
{
    public class Persona 
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}, {Edad} años";
        }
    }

}
