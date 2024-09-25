using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__4
{
    public class DecoradorAlumnoAsteriscos : AlumnoDecorado
    {
        public DecoradorAlumnoAsteriscos(IAlumno alumno) : base(alumno)
        {
        }

        public override string mostrarCalificacion()
        {
            string calificacion = alumno.mostrarCalificacion();

            int tamaño = calificacion.Length + 4;
            string asteriscos = new string('*', tamaño);

            return $"{asteriscos}\n* {calificacion} *\n{asteriscos}";
        }
    }
}
