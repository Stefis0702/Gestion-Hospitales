using HerenciaHospital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaHospital
{
    public class CitasdelDia
    {
        public DateTime Fecha { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public string Hora { get; set; }

        public override string ToString()
        {
           
            return $"{Fecha.ToString("dd/MM/yyyy HH:mm")} - {Paciente.Nombre} {Paciente.Apellido} con Dr(a). {Medico.Nombre} {Medico.Apellido}";
        }
    }
}
