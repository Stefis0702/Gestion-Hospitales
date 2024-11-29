using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaHospital
{
    public class Medico : Persona
    {
        public string Especialidad { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()}, Especialidad: {Especialidad}";
        }
    }
}
