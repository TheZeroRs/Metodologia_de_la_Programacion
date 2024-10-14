using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__5
{
    public class AlumnoMuyEstudioso : Alumno, IAlumno
    {
        public AlumnoMuyEstudioso(string nombre, int edad, int grado, int calificacion, EstrategiaDeComparacion estrategia, int nivel)
        : base(nombre, edad, grado, calificacion, estrategia, nivel)
        {

        }
        public override int responderPregunta(int pregunta) 
        {
            return 3;
        }
    }
}
