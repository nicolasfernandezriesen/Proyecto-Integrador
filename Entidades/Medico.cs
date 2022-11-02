using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico : Persona
    {
        #region Propiedades

        public string Especialidad { get; set; }
        public string Matricula { get; set; }

        #endregion
        #region Constructores

        public Medico() { }

        public Medico(string especialidad, string matricula, int id, string nombre, string apellido, string domicilio, string telefono, string email) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            Especialidad = especialidad;
            Matricula = matricula;
        }

        #endregion
        #region Metodos

        #endregion
    }
}
