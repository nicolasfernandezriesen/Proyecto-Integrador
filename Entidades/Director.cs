using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Director : Medico
    {
        #region Propiedades

        public string PostGrado { get; set; }

        #endregion
        #region Constructores

        public Director() { }

        public Director(string postGrado, string especialidad, string matricula, int id, string nombre, string apellido, string domicilio, long telefono, string email) : base (especialidad, matricula, id, nombre, apellido, domicilio, telefono, email)
        {
            PostGrado = postGrado;
        }

        #endregion
        #region Metodos

        #endregion
    }
}
