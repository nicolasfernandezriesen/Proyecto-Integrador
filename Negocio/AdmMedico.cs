using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public class AdmMedico
    {
        List<Medico> medicos;
        public List<Medico> Listar()
        { 
            medicos = new List<Medico>();
            medicos.Add(new Medico("Clinico", "AB505", 0, "Julio", "Harmo", "Castelli 3025", "223542336", "julha@gmail.com"));
            medicos.Add(new Medico("Clinico", "AB600", 1, "Sol", "Berto", "San Juan 1230", "2236210885", "latu@gmail.com"));
            medicos.Add(new Medico("Pediatra", "AA001", 2, "Luna", "Nikka", "Corrientes 760", "2235622100", "l.kka@gmail.com"));
            medicos.Add(new Medico("Traumatologo", "CR996", 3, "Juan", "Colli", "Guemes 1003", "2235745513", "collijuan@gmail.com"));
            medicos.Add(new Medico("Cardiologo", "AB532", 4, "Federico", "Topasio", "Avellaneda 2356", "2236982447", "heartattack@gmail.com"));

            return medicos;
        }

        public List<Medico> Listar(string especialidad)
        {
            //TODO completar funcion 
            return null;
        }

        public int Insertar(Medico medico)
        {
            //TODO completar codigo
            return 0;
        }

        public int Eliminar(int id)
        {
            //TODO completar codigo
            return 0;
        }

        public Paciente TraerUno(string nroHistoriaClinica)
        {
            //TODO completar codigo
            return null;
        }
    }
}
