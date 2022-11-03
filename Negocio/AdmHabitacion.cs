using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmHabitacion
    {
        public static List<Habitacion> Listar()
        {
            List<Habitacion> habitaciones = new List<Habitacion>();
            habitaciones.Add(new Habitacion(0, 113, true));
            habitaciones.Add(new Habitacion(1, 111, false));
            habitaciones.Add(new Habitacion(2, 211, true));
            habitaciones.Add(new Habitacion(3, 126, false));
            habitaciones.Add(new Habitacion(4, 222, false));
            return habitaciones;
        }

        public static List<Habitacion> Listar(int estado)
        {
            //TODO completar codigo
            return null;
        }

        public static int Insertar(Habitacion habitacion)
        {
            //TODO completar codigo
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO completar codigo
            return 0;
        }

        public static Habitacion TraerUno(int numero)
        {
            //TODO completar codigo
            return null;
        }
    }
}
