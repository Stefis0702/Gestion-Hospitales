using HerenciaHospital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gestion_Hospitales
{
    public partial class Principal : Form
    {
      private Hospital hospital = new Hospital();
        public Principal()
        {
            InitializeComponent();
            hospital = new Hospital();  
            AgregarCitasDePrueba();
            CargarCitasDelDia();
            InicializarComponentesListarEliminar();
        }
        private void InicializarComponentesListarEliminar()
        {
            // Configura  opciones del ComboBox
            cmbPersona.Items.Clear();
            cmbPersona.Items.Add("Médicos");
            cmbPersona.Items.Add("Pacientes por Médico");

            // Oculta componentes 
            lbSelMedico.Visible = false;
            cmbSelMedico.Visible = false;
            listBoxResultados.Visible = true;

            cmbPersona.SelectedIndexChanged += CmbPersona_SelectedIndexChanged;

            hospital.ActualizarComboBoxMedicos(cmbSelMedico);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar agregarForm = new Agregar(hospital);
            agregarForm.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string opcionSeleccionada = cmbPersona.SelectedItem.ToString();
            hospital.ListarPacientesOMedicos(opcionSeleccionada, cmbSelMedico, listBoxResultados);
        }
        private void CmbPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPersona.SelectedItem != null)
            {
                string seleccion = cmbPersona.SelectedItem.ToString();

                
                if (seleccion == "Pacientes por Médico")
                {
                    lbSelMedico.Visible = true;
                    cmbSelMedico.Visible = true;
                }
                else
                {
                    lbSelMedico.Visible = false;
                    cmbSelMedico.Visible = false;
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxResultados.SelectedItem != null)
            {
                string pacienteSeleccionadoStr = listBoxResultados.SelectedItem.ToString();
                Medico medicoSeleccionado = cmbSelMedico.SelectedItem as Medico;

                if (medicoSeleccionado != null)
                {
                    Paciente pacienteSeleccionado = ObtenerPacienteDesdeString(pacienteSeleccionadoStr, medicoSeleccionado);
                    if (pacienteSeleccionado != null)
                    {
                        hospital.EliminarPaciente(medicoSeleccionado, pacienteSeleccionado);
                        MessageBox.Show("Paciente eliminado exitosamente.");
                        listBoxResultados.Items.Remove(pacienteSeleccionadoStr);
                    }
                }
            }
        }
        private Paciente ObtenerPacienteDesdeString(string pacienteStr, Medico medico)
        {
            foreach (var paciente in hospital.pacientesPorMedico[medico])
            {
                string pacienteText = paciente.ToString();
                if (pacienteText == pacienteStr)
                {
                    return paciente;
                }
            }
            return null; 
        }
        private void CargarCitasDelDia()
        {
            lbCitasDia.Items.Clear();

            List<CitasdelDia> citasDelDia = hospital.ObtenerCitasDelDia();

            foreach (var cita in citasDelDia)
            {
                lbCitasDia.Items.Add(cita); 
            }
        }
        private void AgregarCitasDePrueba()
        {
            
            Medico medico1 = new Medico { Nombre = "Javier", Apellido = "Perez", Edad= 43, Especialidad= "Medicina Interna" };
            Medico medico2 = new Medico { Nombre = "Andres", Apellido= "García", Edad = 35, Especialidad = "Traumatologia" };
            Paciente paciente1 = new Paciente { Nombre = "Juan", Apellido = "López", Edad = 35, MotivoConsulta = "Resfriado" };
            Paciente paciente2 = new Paciente { Nombre = "María", Apellido = "Sánchez", Edad = 63, MotivoConsulta = "Dolor Rodilla Derecha" };

            hospital.AgregarMedico(medico1);
            hospital.AgregarMedico(medico2);
            hospital.AgregarPaciente(medico1,paciente1);
            hospital.AgregarPaciente(medico2,paciente2);

            CitasdelDia cita1 = new CitasdelDia
            {
                Fecha = DateTime.Today.AddHours(10),  
                Medico = medico1,
                Paciente = paciente1,
                Hora = "10:00"
            };

            CitasdelDia cita2 = new CitasdelDia
            {
                Fecha = DateTime.Today.AddHours(14), 
                Medico = medico2,
                Paciente = paciente2,
                Hora = "14:00"
            };

            
            hospital.AgregarCita(cita1);
            hospital.AgregarCita(cita2);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = e.Start;
            lbCitasDia.Items.Clear();
            List<CitasdelDia> citasDelDia = hospital.ObtenerCitasDelDiaPorFecha(fechaSeleccionada);
            foreach (var cita in citasDelDia)
            {
                lbCitasDia.Items.Add(cita); 
            }
        }
    }
}
