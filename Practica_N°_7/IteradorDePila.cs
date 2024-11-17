using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__7
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
            this.indice = p.Cuantos() - 1;
        }
        
        public void Siguiente()
        {
            this.indice--;
        }

        public bool Fin()
        {
            return this.indice < 0;
        }

        public Comparable Actual()
        {
            if (indice >= 0 && indice < p.Cuantos())
            {
                return this.p.GetElementos()[indice];
            }
            else
            {
                throw new InvalidOperationException("No hay más elementos en la pila.");
            }
        }
    } 

}