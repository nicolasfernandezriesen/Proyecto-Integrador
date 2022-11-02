using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Habitacion
    {
        #region Propiedades

        public int Id { get; set; }
        public int Numero { get; set; }
        public Boolean Estado { get; set; }

        #endregion
        #region Constructores

        public Habitacion() { }

        public Habitacion(int id, int numero, bool estado)
        {
            Id = id;
            Numero = numero;
            Estado = estado;
        }

        #endregion
        #region Metodos

        #endregion
    }
}
