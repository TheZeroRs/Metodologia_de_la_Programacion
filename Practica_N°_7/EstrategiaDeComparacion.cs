using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__7
{
    public interface EstrategiaDeComparacion
    {
        bool SosIgual(Alumno alumno1, Alumno alumno2);
        bool SosMenor(Alumno alumno1, Alumno alumno2);
        bool SosMayor(Alumno alumno1, Alumno alumno2);
    }
}