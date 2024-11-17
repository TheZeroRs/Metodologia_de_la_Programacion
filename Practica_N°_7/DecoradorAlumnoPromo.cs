using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__7
{
    public class DecoradorAlumnoPromo : AlumnoDecorado
    {
        public DecoradorAlumnoPromo(IAlumno alumno) : base(alumno)
        {
        }

        public override string mostrarCalificacion()
        {
            return $"{_alumno.mostrarCalificacion()} ({_promocion(_alumno.getCalificacion())})";
        }

        private string _promocion(int promo) 
        {
            if (promo >= 7) return "PROMOCION";
            if (promo >= 4) return "APROBADO";
            return "DESAPROBADO";
        }

    }
}
