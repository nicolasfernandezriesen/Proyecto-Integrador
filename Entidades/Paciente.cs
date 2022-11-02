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

        #endregion
        #region Constructores

        public Paciente() { }

        public Paciente(string nroHistoriaClinico, int id, string nombre, string apellido, string domicilio, string telefono, string email) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            NroHistoriaClinico = nroHistoriaClinico;
        }

        #endregion
        #region Metodos

        #endregion
    }
}
