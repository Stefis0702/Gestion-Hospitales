using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaHospital
{
    public class Paciente : Persona
    {
        public string MotivoConsulta { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()}, Motivo de consulta: {MotivoConsulta}";
        }

    }
}
