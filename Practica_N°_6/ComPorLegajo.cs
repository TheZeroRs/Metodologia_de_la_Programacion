using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__6
{
    public class ComPorLegajo : EstrategiaDeComparacion
    {
        public bool SosIgual(Alumno a1, Alumno a2)
        {
            return a1.getLegajo() == a2.getLegajo();
        }
        public bool SosMenor(Alumno a1, Alumno a2)
        {
            return a1.getLegajo() < a2.getLegajo();
        }
        public bool SosMayor(Alumno a1, Alumno a2)
        {
            return a1.getLegajo() > a2.getLegajo();
        }
    }

}