using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enfermero : Persona
    {
        #region Propiedades

        public int Cuil { get; set; }

        #endregion
        #region Constructores

        public Enfermero() { }

        public Enfermero(int cuil, int id, string nombre, string apellido, string domicilio, long telefono, string email) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            Cuil = cuil;
        }

        #endregion
        #region Metodos

        #endregion
    }
}
