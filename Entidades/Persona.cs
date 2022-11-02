using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Propiedades

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public long Telefono { get; set; }
        public string Email { get; set; }

        #endregion
        #region Constructores

        public Persona() { }

        public Persona(int id, string nombre, string apellido, string domicilio, long telefono, string email)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Domicilio = domicilio;
            Telefono = telefono;
            Email = email;
        }

        #endregion
        #region Metodos

        #endregion
    }
}
