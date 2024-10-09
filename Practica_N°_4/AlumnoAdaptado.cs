using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__4
{
    public class AlumnoAdaptado : Student, IAlumno
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

        public int getLegajo()
        {
            throw new NotImplementedException();
        }

        public void setLegajo(int legajo)
        {
            throw new NotImplementedException();
        }

        public int getPromedio()
        {
            throw new NotImplementedException();
        }

        public void setPromedio(int promedio)
        {
            throw new NotImplementedException();
        }

        public int getCalificacion()
        {
            return alumno.getCalificacion();
        }

        public void setCalificacion(int calificacion)
        {
            throw new NotImplementedException();
        }

        public void setEstrategia(EstrategiaDeComparacion estrategia)
        {
            throw new NotImplementedException();
        }

        public EstrategiaDeComparacion getEstrategia()
        {
            throw new NotImplementedException();
        }

        public string mostrarCalificacion()
        {
            return showResult();
        }

        public int responderPregunta(int pregunta)
        {
            throw new NotImplementedException();
        }
    }
}
