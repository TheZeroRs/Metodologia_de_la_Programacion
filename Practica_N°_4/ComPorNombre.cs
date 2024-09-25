using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__4
{
    public class ComPorNombre : EstrategiaDeComparacion
    {
        public bool SosIgual(Alumno a1, Alumno a2)
        {
            return a1.GetNombre().CompareTo(a2.GetNombre) == 0;
        }

        public bool SosMenor(Alumno a1, Alumno a2)
        {
            return a1.GetNombre().CompareTo(a2.GetNombre()) < 0;
        }

        public bool SosMayor(Alumno a1, Alumno a2)
        {
            return a1.GetNombre().CompareTo(a2.GetNombre()) > 0;
        }

    }
}
