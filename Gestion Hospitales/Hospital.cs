using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaHospital
{
    public class Hospital
    {
        public List<Medico> medicos = new List<Medico>();
        public Dictionary<Medico, List<Paciente>> pacientesPorMedico = new Dictionary<Medico, List<Paciente>>();
        public List<CitasdelDia> Citas { get; set; } = new List<CitasdelDia>();

        public bool AgregarMedico(Medico medico)
        {
            if (medico == null)
            {
                Console.WriteLine("No se puede agregar un médico nulo.");
                return false;
            }
            if (medicos.Contains(medico))
            {
                Console.WriteLine("El médico ya existe en la lista.");
                return false;
            }
            medicos.Add(medico);
            pacientesPorMedico[medico] = new List<Paciente>();
            Console.WriteLine("Médico agregado exitosamente.");
            return true;
        }
        public bool AgregarPaciente(Medico medico, Paciente paciente)
        {

            if (medico == null)
            {
                Console.WriteLine("No se puede agregar un paciente a un médico nulo.");
                return false;
            }
            if (paciente == null)
            {
                Console.WriteLine("No se puede agregar un médico nulo.");
                return false;
            }
            if (!pacientesPorMedico.ContainsKey(medico))
            {
                Console.WriteLine("El médico no está registrado.");
                return false;
            }

            pacientesPorMedico[medico].Add(paciente);
            Console.WriteLine("Paciente agregado exitosamente.");
            return true;
        }
        public List<string> ListarMedicos()
        {
            List<string> medicosList = new List<string>();
            foreach (var medico in medicos)
            {
                medicosList.Add($"{medico.Nombre} {medico.Apellido} - {medico.Especialidad}");
            }
            return medicosList;
        }

        
        public List<Paciente> ListarPacientesPorMedico(Medico medico)
        {
            List<Paciente> pacientesList = new List<Paciente>();
            if (pacientesPorMedico.ContainsKey(medico))
            {
                pacientesList = pacientesPorMedico[medico];  
            }
            return pacientesList;
        }
        public void EliminarPaciente(Medico medico, Paciente paciente)
        {
            if (pacientesPorMedico.ContainsKey(medico))
            {
                pacientesPorMedico[medico].Remove(paciente);
            }
        }
        public void ListarPersonas()
        {
            foreach (var medico in medicos)
            {
                Console.WriteLine(medico);
                foreach (var paciente in pacientesPorMedico[medico])
                {
                    Console.WriteLine($"  - {paciente}");
                }
            }
        }
        public void ListarPacientesOMedicos(string tipo, ComboBox cmbSelMedico, ListBox listBoxResultados)
        {
            listBoxResultados.Items.Clear();  

            if (tipo == "Médicos")
            {
               
                foreach (var medico in medicos)
                {
                    listBoxResultados.Items.Add(medico.ToString());
                }
            }
            else if (tipo == "Pacientes por Médico")
            {
               
                if (cmbSelMedico.SelectedItem != null)
                {
                    Medico medicoSeleccionado = cmbSelMedico.SelectedItem as Medico;
                    if (medicoSeleccionado != null)
                    {
                        foreach (var paciente in pacientesPorMedico[medicoSeleccionado])
                        {
                            listBoxResultados.Items.Add(paciente.ToString());
                        }
                    }
                }
            }

            listBoxResultados.Visible = true;  
        }
        public void ActualizarComboBoxMedicos(ComboBox cmbSelMedico)
        {
            cmbSelMedico.Items.Clear();
            foreach (var medico in medicos)  
            {
                cmbSelMedico.Items.Add(medico);
            }
        }

        public List<CitasdelDia> ObtenerCitasDelDia()
        {
            DateTime hoy = DateTime.Today;
            return Citas.Where(c => c.Fecha.Date == hoy).ToList();
        }
        public void AgregarCita(CitasdelDia cita)
        {
            Citas.Add(cita);
        }
       

    }

}

