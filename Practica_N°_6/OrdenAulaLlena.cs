using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__6
{
    public class OrdenAulaLlena: IOrdenEnAula1
    {
        private Aula aula;
        public OrdenAulaLlena(Aula aula) 
        {
            this.aula = aula;
        }

        public void Ejecutar() 
        {
            this.aula.ClaseLista();
        }
    }
}
