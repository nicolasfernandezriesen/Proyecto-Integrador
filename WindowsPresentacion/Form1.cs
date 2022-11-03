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

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            pacientes = new List<Paciente>();
            medicos = new List<Medico>();
            habitaciones = new List<Habitacion>();

            pacientes = AdmPaciente.Listar();
            medicos = AdmMedico.Listar();
            habitaciones = AdmHabitacion.Listar();

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
