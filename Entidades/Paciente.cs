using Entidades.Ayudantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        #region Propiedades

        public string NroHistoriaClinico { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad {
            get
            {
                return UtilidadesFechas.CalcularEdad(FechaNacimiento);
            } 
        }

        #endregion
        #region Constructores

        public Paciente() { }

        public Paciente(string nroHistoriaClinico, DateTime fechanacimieto, int id, string nombre, string apellido, string domicilio, string telefono, string email) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            NroHistoriaClinico = nroHistoriaClinico;
            FechaNacimiento = fechanacimieto;
        }

        #endregion
        #region Metodos

        #endregion
    }
}
