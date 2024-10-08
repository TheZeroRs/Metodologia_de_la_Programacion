using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__4
{
    public abstract class AlumnoDecorado : IAlumno
    {
        protected IAlumno alumno;

        public AlumnoDecorado(IAlumno alumno) 
        {
            this.alumno = alumno;
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

        public virtual string mostrarCalificacion() 
        {
            return this.alumno.mostrarCalificacion();
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
