using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ayudantes
{
    public static class UtilidadesFechas
    {
        public static int CalcularEdad(DateTime birthDate)
        {
            DateTime today = DateTime.Today;

            int edad = Convert.ToInt32(today.Year) - Convert.ToInt32(birthDate.Year);

            return edad;
        }
    }
}
