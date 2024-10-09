using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__5
{
    public class Cola : Coleccionable, Iterable
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

        public bool EsVacia()
        {
            return this.Cuantos() == 0;
        }

        public Iterador CrearIterador()
        {
            return new IteradorDeCola(this);
        }

        public List<Comparable> GetElementos()
        {
            return new List<Comparable>(elementos);
        }
    }
}
