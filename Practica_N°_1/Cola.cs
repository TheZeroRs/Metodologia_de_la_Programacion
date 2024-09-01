using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__1
{
    internal class Cola : Coleccionable
    {
        List<Comparable> elementos;
        public Cola()
        {
            this.elementos = new List<Comparable>();
        }

        public void AñadirCola(Comparable com) 
        {
            this.elementos.Add(com);
        }

        public Comparable QuitarCola()
        {
            Comparable com = this.elementos[0];
            this.elementos.RemoveAt(0);
            return com;
        }
        public int Cuantos()
        {
            return elementos.Count;
        }

        public Comparable Minimo() 
        {
            Comparable com = this.elementos[0];
            for (int i = 0; i < elementos.Count; i++)
            {
                if (com.SosMenor(this.elementos[i]))
                {
                    com = this.elementos[i];
                }
            }
            return com;
        }
        public Comparable Maximo()
        {
            Comparable com = this.elementos[0];
            for (int i = 0; i < elementos.Count; i++)
            {
                if (com.SosMayor(this.elementos[i]))
                {
                    com = this.elementos[i];
                }
            }
            return com;
        }
        public void Agregar(Comparable com)
        {
            this.AñadirCola(com);
        }

        public bool Contiene(Comparable com)
        {
            for (int i = 0; i < elementos.Count; i++)
            {
                if (com.SosIgual(this.elementos[i]))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
