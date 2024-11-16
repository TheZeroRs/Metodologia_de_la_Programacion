using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__6
{
    public class OrdenLlegaAlumno : IOrdenEnAula2
    {
        private Aula aula;
        public OrdenLlegaAlumno(Aula aula) 
        {
            this.aula = aula;
        }
        public void Ejecutar(Comparable com)
        {
            aula.NuevoAlumno((IAlumno)com);
        }
    }
}
