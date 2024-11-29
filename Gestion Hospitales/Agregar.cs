using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerenciaHospital;

namespace Gestion_Hospitales
{
    public partial class Agregar : Form
    {


        private Hospital hospital;
        public Agregar(Hospital hospital)
        {
            this.hospital = hospital;
            InitializeComponent();
            listBox1.SendToBack();
            cmbPersona.Items.Clear();
            cmbPersona.Items.Add("Médico");
            cmbPersona.Items.Add("Paciente");
          
            OcultarTodosLosControles();
        }

      
        private void cmbPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoPersona = cmbPersona.SelectedItem.ToString();
            MostrarPanelPersona(tipoPersona);
        }

      
        private void MostrarPanelPersona(string tipoPersona)
        {
            LimpiarCampos(); 
           
            OcultarTodosLosControles();

            if (tipoPersona == "Médico")
            {
                lbNombre.Visible = true;
                txtNombre.Visible = true;

                lbApellido.Visible = true;
                txtApellido.Visible = true;

                lbEdad.Visible = true;
                txtEdad.Visible = true;

                lbEspecialidad.Visible = true;
                txtEspecialidad.Visible = true;
                pbFoto.Visible = true;
            }
            else if (tipoPersona == "Paciente")
            {
                lbNombre.Visible = true;
                txtNombre.Visible = true;

                lbApellido.Visible = true;
                txtApellido.Visible = true;

                lbEdad.Visible = true;
                txtEdad.Visible = true;

                lbMotivoConsulta.Visible = true;
                txtMotivoConsulta.Visible = true;

                lbSelMedico.Visible = true;
                cmbSelMedico.Visible = true;

                pbFoto.Visible = true;


                ActualizarComboBoxMedicos();
            }
        }

        private void OcultarTodosLosControles()
        {
            lbNombre.Visible = false;
            txtNombre.Visible = false;

            lbApellido.Visible = false;
            txtApellido.Visible = false;

            lbEdad.Visible = false;
            txtEdad.Visible = false;

            lbEspecialidad.Visible = false;
            txtEspecialidad.Visible = false;

            lbMotivoConsulta.Visible = false;
            txtMotivoConsulta.Visible = false;

            lbSelMedico.Visible = false;
            cmbSelMedico.Visible = false;

            pbFoto.Visible = false;
        }

     
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtEspecialidad.Clear();
            txtMotivoConsulta.Clear();
        }

        
        private void btnCrear_Click(object sender, EventArgs e)
        {
          
                if (cmbPersona.SelectedItem.ToString() == "Médico")
                {
                    Medico medico = ObtenerMedicoDesdeFormulario();
                    if (medico != null)
                    {
                        if (hospital.medicos.Any(m => m.Nombre == medico.Nombre && m.Apellido == medico.Apellido && m.Especialidad == medico.Especialidad))
                        {
                            MessageBox.Show("El médico ya existe. No se puede agregar duplicado.");
                            return;
                        }

                        hospital.AgregarMedico(medico);
                        MessageBox.Show("Médico agregado exitosamente.");
                        ActualizarComboBoxMedicos();
                        LimpiarCampos();
                }
                }
               
                else if (cmbPersona.SelectedItem.ToString() == "Paciente")
                {
                    Paciente paciente = ObtenerPacienteDesdeFormulario();
                    if (paciente != null)
                    {
                        Medico medicoSeleccionado = cmbSelMedico.SelectedItem as Medico;
                        if (medicoSeleccionado != null)
                        {

                            hospital.AgregarPaciente(medicoSeleccionado, paciente);
                            MessageBox.Show("Paciente agregado exitosamente.");
                            LimpiarCampos();
                    }
                    }
                }
            
        }

        public Medico ObtenerMedicoDesdeFormulario()
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad;
            string especialidad = txtEspecialidad.Text;

            bool isValidEdad = int.TryParse(txtEdad.Text, out edad);

            if (isValidEdad && !string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(especialidad))
            {
                return new Medico
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Edad = edad,
                    Especialidad = especialidad
                };
            }
            else
            {
                MessageBox.Show("Por favor, ingrese todos los datos válidos para el médico.");
                return null;
            }
        }

        
        private Paciente ObtenerPacienteDesdeFormulario()
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad;
            string motivoConsulta = txtMotivoConsulta.Text;

            bool isValidEdad = int.TryParse(txtEdad.Text, out edad);

            if (isValidEdad && !string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(motivoConsulta))
            {
                Medico medicoSeleccionado = cmbSelMedico.SelectedItem as Medico;
                if (medicoSeleccionado == null)
                {
                    MessageBox.Show("Por favor, seleccione un médico para asignar al paciente.");
                    return null;
                }

                return new Paciente
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Edad = edad,
                    MotivoConsulta = motivoConsulta
                };
            }
            else
            {
                MessageBox.Show("Por favor, ingrese todos los datos válidos para el paciente.");
                return null;
            }
        }


        private void ActualizarComboBoxMedicos()
        {
            cmbSelMedico.Items.Clear();
            foreach (Medico medico in hospital.medicos)
            {
                cmbSelMedico.Items.Add(medico);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
