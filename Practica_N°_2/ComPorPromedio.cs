using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__2
{
    public class ComPorPromedio
    {
        public bool SosIgual(Alumno a1, Alumno a2)
        {
            return a1.getPromedio() == a2.getPromedio();
        }
        public bool SosMenor(Alumno a1, Alumno a2)
        {
            return a1.getPromedio() < a2.getPromedio();
        }
        public bool SosMayor(Alumno a1, Alumno a2)
        {
            return a1.getPromedio() > a2.getPromedio();
        }
    }
}
