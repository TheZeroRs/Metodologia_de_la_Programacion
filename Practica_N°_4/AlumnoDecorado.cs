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

        public int getCalificacion()
        {
            return this._alumno.getCalificacion();
        }

        public EstrategiaDeComparacion getEstrategia()
        {
            throw new NotImplementedException();
        }

        public int getLegajo()
        {
            return _alumno.getLegajo();
        }

        public int getPromedio()
        {
            throw new NotImplementedException();
        }

        public int responderPregunta(int pregunta)
        {
            return _alumno.responderPregunta(pregunta);
        }

        public void setCalificacion(int calificacion)
        {
            _alumno.setCalificacion(calificacion);
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

        public bool SosIgual(Comparable com)
        {
            return _alumno.SosIgual(com);
        }

        public bool SosMenor(Comparable com)
        {
            return _alumno.SosMenor(com);
        }

        public bool SosMayor(Comparable com)
        {
            return _alumno.SosMayor(com);
        }

        public string GetNombre()
        {
            return _alumno.GetNombre();
        }
    }
}
