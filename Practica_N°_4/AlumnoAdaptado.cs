using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__4
{
    public class AlumnoAdaptado : Student 
    {
        public Alumno alumno;

        public AlumnoAdaptado(Alumno alumno) 
        {
            this.alumno = alumno;
        }

        public string getName() 
        {
            return this.alumno.GetNombre();
        }

        public int yourAnswerIs(int question)
        {
            return this.alumno.responderPregunta(question);
        }

        public void setScore(int score)
        {
           this.alumno.setCalificacion(score);
        }

        public string showResult()
        {
            return this.alumno.mostrarCalificacion();
        }

        public bool equals(Student student)
        {
            if (student is AlumnoAdaptado otroAdaptado)
            {
                return this.alumno.SosIgual(otroAdaptado.alumno);
            }
            return false;
        }

        public bool lessThan(Student student)
        {
            if (student is AlumnoAdaptado otroAdaptado)
            {
                return this.alumno.SosMenor(otroAdaptado.alumno);
            }
            return false;
        }

        public bool greaterThan(Student student)
        {
            if (student is AlumnoAdaptado otroAdaptado)
            {
                return this.alumno.SosMayor(otroAdaptado.alumno);
            }
            return false;
        }
    }
}
