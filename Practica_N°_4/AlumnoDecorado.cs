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

        public virtual string mostrarCalificacion() 
        {
            return this.mostrarCalificacion();
        }
    }
}
