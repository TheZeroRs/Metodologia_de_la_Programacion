using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__1
{
    internal class ColeccionMultiple : Coleccionable
    {
        Pila pila { get; set; }
        Cola cola { get; set; }
    
        public ColeccionMultiple (Pila pila, Cola cola) 
        {
            this.pila = pila;
            this.cola = cola;
        }

        public int Cuantos()
        {
            int pilaCount = this.pila.Cuantos();
            int colaCount = this.cola.Cuantos();
            return (pilaCount + colaCount);
        }

        public Comparable Minimo()
        {
            Comparable pilaM = this.pila.Minimo();
            Comparable colaM = this.cola.Minimo();
            if (pilaM.SosMenor(colaM)) 
            {
                return pilaM;
            }
            else 
            {
                return colaM;
            }
        }

        public Comparable Maximo()
        {
            Comparable pilaM = this.pila.Maximo();
            Comparable colaM = this.cola.Maximo();
            if (pilaM.SosMayor(colaM))
            {
                return pilaM;
            }
            else
            {
                return colaM;
            }
        }

        public void Agregar(Comparable com)
        {
            throw new NotImplementedException();
        }

        public bool Contiene(Comparable com)
        {
            if(this.pila.Contiene(com)) 
            {
                return true;
            }
            if (this.cola.Contiene(com))
            {
                return true;
            }
            else 
            {
                return false; 
            }
        }
    }
}
