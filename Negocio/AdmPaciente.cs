﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmPaciente
    {
        public static List<Paciente> Listar()
        {
            List<Paciente> pacientes = new List<Paciente>();
            pacientes.Add(new Paciente("MMD0023GA", new DateTime(2002,02,03),0, "Julian", "Norak", "Alvarado 2259", "2235802647", "pota@gmail.com"));
            pacientes.Add(new Paciente("AGKT77890DR", new DateTime(1983, 09, 22), 1, "Thiago", "Giler", "España 3750", "2235554111", "monster56@gmail.com"));
            pacientes.Add(new Paciente("TTYI54021FF", new DateTime(2009, 05, 01), 2, "Emilia", "Ciel Korat", "Alvarado 2014", "2235996320", "rosaliiia@gmail.com"));
            pacientes.Add(new Paciente("AJKI9956OP", new DateTime(1965, 12, 25), 3, "Luis", "Alfonso", "Buenos Aires 2066", "2235554882", "jate@gmail.com"));
            pacientes.Add(new Paciente("IKKADE88522II", new DateTime(2016, 04, 13), 4, "Maria Paz", "Terri", "Cordoba 3287", "2235666899", "cieloJio@gmail.com"));
            return pacientes;
        }

        public static int Insertar(Paciente paciente)
        {
            //TODO completar codigo
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO completar codigo
            return 0;
        }

        public static Paciente TraerUno(string nroHistoriaClinica)
        {
            //TODO completar codigo
            return null;
        }
    }
}
