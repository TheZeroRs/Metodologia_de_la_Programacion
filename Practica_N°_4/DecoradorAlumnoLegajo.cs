using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__4
{
    public class DecoradorAlumnoLegajo : AlumnoDecorado
    {
        public DecoradorAlumnoLegajo(IAlumno alumno) : base(alumno)
        {
        }
        public override string mostrarCalificacion()
        {
            string calificacionCompleta = _alumno.mostrarCalificacion();
            var partes = calificacionCompleta.Split(' ');
            string nombre = string.Join(" ", partes);
            string calificacion = partes.Last();

            return $"{nombre} ({_alumno.getLegajo} ) {calificacion}";
        }
    }
}
