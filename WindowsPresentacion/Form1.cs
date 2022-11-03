using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        List<Paciente> pacientes;
        List<Medico> medicos;
        List<Habitacion> habitaciones;
        AdmMedico admMedico;
        AdmPaciente admPaciente;
        AdmHabitacion admHabitacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            pacientes = new List<Paciente>();
            medicos = new List<Medico>();
            habitaciones = new List<Habitacion>();
            admPaciente = new AdmPaciente();
            admMedico = new AdmMedico();
            admHabitacion = new AdmHabitacion();

            pacientes = admPaciente.Listar();
            medicos = admMedico.Listar();
            habitaciones = admHabitacion.Listar();

            MessageBox.Show("Sistema cargado correctamente");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            gridPacientes.DataSource = pacientes;
            gridMedicos.DataSource = medicos;

            int cont = 0;
            foreach (var medico in medicos)
            {
                if (medico.Especialidad.ToLower() == "clinico")
                {
                    lstMedicosClinicos.Items.Add(medico.Nombre + " " + medico.Apellido);
                    cont++;
                }
            }
            lstMedicosClinicos.Items.Add(cont.ToString());

            string estado;
            foreach (var habitacion in habitaciones)
            {
                if (habitacion.Estado == true)
                {
                    estado = "Ocupado";
                }
                else
                {
                    estado = "Libre";
                }
                lstHabitaciones.Items.Add(habitacion.Numero.ToString() + " " + estado);
            }

        }
    }
}
