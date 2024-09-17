using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__2
{
    public class IteradorDePila : Iterador
    {
        Pila p;
        int indice;
        public IteradorDePila(Pila p)
        {
            this.p = p;
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
            return this.indice >= p.Cuantos();
        }

        public Comparable Actual()
        {
           return this.p.GetElementos()[indice];
        }
    } 

}