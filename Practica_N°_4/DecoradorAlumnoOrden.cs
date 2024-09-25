using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__4
{
    public class DecoradorAlumnoOrden : AlumnoDecorado
    {
        private int orden;

        public DecoradorAlumnoOrden(IAlumno alumno, int orden) : base(alumno)
        {
            this.orden = orden;
        }

        public override string mostrarCalificacion()
        {
            return $"{orden}) {alumno.mostrarCalificacion()}";
        }
    }
}
