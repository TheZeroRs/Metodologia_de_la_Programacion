using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__6
{
    public class IteradorDeCola : Iterador
    {
        Cola c;
        int indice;
        public IteradorDeCola(Cola c)
        {
            this.c = c;
            Primero();
        }

        public void Primero()
        {
            this.indice = 0;
        }

        public void Siguiente()
        {
            this.indice++;
        }

        public bool Fin()
        {
            return this.indice >= c.Cuantos();
        }

        public Comparable Actual()
        {
           return this.c.GetElementos()[indice];
        }
    }
}
