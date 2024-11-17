using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__7
{
    public class AlumnoMuyEstudioso : Alumno, IAlumno
    {
        public AlumnoMuyEstudioso(string nombre, int dni, int legajo,int promedio, EstrategiaDeComparacion estrategia, int calificacion)
        : base(nombre, dni, legajo, promedio, estrategia, calificacion)
        {

        }
        public override int responderPregunta(int pregunta) 
        {
            return pregunta % 3;
        }
    }
}
