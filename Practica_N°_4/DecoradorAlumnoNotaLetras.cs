using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__4
{
    public class DecoradorAlumnoNotaLetras : AlumnoDecorado
    {
        public DecoradorAlumnoNotaLetras(IAlumno alumno) : base(alumno)
        {
        }
        public override string mostrarCalificacion()
        {
            return $"{alumno.mostrarCalificacion()} ({_convertirNumeroALetra(alumno.getCalificacion())}";
        }

        private string _convertirNumeroALetra(int calificacion)
        {
            return calificacion switch
            {
                10 => "DIEZ",
                9 => "NUEVE",
                8 => "OCHO",
                7 => "SIETE",
                6 => "SEIS",
                5 => "CINCO",
                4 => "CUATRO",
                3 => "TRES",
                2 => "DOS",
                1 => "UNO",
                0 => "CERO",
                _ => "DESCONOCIDA"
            };
        }
    }
}
