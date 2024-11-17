using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__7
{
    public class OrdenInicio: IOrdenEnAula1
    {
        private Aula aula;
        public OrdenInicio(Aula aula) 
        {
            this.aula = aula;
        }
        public void Ejecutar() 
        {
            aula.Comenzar();
        }
    }
}
