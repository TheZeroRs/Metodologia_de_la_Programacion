using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__7
{
    public class Aula
    {
        Teacher teacher = null;

        public void Comenzar() 
        {
            teacher = new Teacher();
        }

        public void NuevoAlumno(IAlumno alumno) 
        {
            AlumnoAdaptado a = new AlumnoAdaptado(alumno);
            teacher.goToClass(a);
        }

        public void ClaseLista() 
        {
            teacher.teachingAClass();
        }
    }
}
