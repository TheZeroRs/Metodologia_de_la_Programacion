using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__4
{
    public abstract class AlumnoDecorado : IAlumno
    {
        protected IAlumno _alumno;

        public AlumnoDecorado(IAlumno alumno) 
        {
            this._alumno = alumno;
        }

        public virtual string mostrarCalificacion()
        {
            return this._alumno.mostrarCalificacion();
        }


        public AlumnoAdaptado GetAlumnoAdaptado()
        {
            if (_alumno is AlumnoAdaptado)
            {
                return (AlumnoAdaptado)_alumno;
            }
            else if (_alumno is AlumnoDecorado decorado)
            {
                return decorado.GetAlumnoAdaptado();
            }
            throw new InvalidCastException("El objeto no es de tipo AlumnoAdaptado.");
        }




        public int getCalificacion()
        {
            throw new NotImplementedException();
        }

        public EstrategiaDeComparacion getEstrategia()
        {
            throw new NotImplementedException();
        }

        public int getLegajo()
        {
            throw new NotImplementedException();
        }

        public int getPromedio()
        {
            throw new NotImplementedException();
        }

        public int responderPregunta(int pregunta)
        {
            throw new NotImplementedException();
        }

        public void setCalificacion(int calificacion)
        {
            throw new NotImplementedException();
        }

        public void setEstrategia(EstrategiaDeComparacion estrategia)
        {
            throw new NotImplementedException();
        }

        public void setLegajo(int legajo)
        {
            throw new NotImplementedException();
        }

        public void setPromedio(int promedio)
        {
            throw new NotImplementedException();
        }
    }
}
