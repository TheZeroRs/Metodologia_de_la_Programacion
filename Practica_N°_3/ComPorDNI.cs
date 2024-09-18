using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__3
{
    public class ComPorDNI : EstrategiaDeComparacion
    {
        public bool SosIgual(Alumno a1, Alumno a2)
        {
            return a1.GetDni() == a2.GetDni();
        }
        public bool SosMenor(Alumno a1, Alumno a2)
        {
            return a1.GetDni() < a2.GetDni();
        }
        public bool SosMayor(Alumno a1, Alumno a2)
        {
            return a1.GetDni() > a2.GetDni();
        }

    }
}
