using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clinica
    {
        #region Propiedades

        public int Id { get; set; }
        public string Name { get; set; }
        public string Domicilio { get; set; }
        public long Telefono { get; set; }
        public string Email { get; set; }

        #endregion
        #region Constructores

        public Clinica() { }

        public Clinica(int id, string name, string domicilio, long telefono, string email)
        {
            Id = id;
            Name = name;
            Domicilio = domicilio;
            Telefono = telefono;
            Email = email;
        }

        #endregion
        #region Metodos

        #endregion
    }
}
