using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__7
{
    public class Pila : Coleccionable, Iterable, IOrdenable
    {
        IOrdenEnAula1 ordenInicio = null, ordenFin = null;
        IOrdenEnAula2 ordenAlumno = null;

        List<Comparable> elementos;
        public Pila() 
        {
            this.elementos = new List<Comparable>();
        }
        public void Apilar(Comparable com) 
        {
            this.elementos.Add(com);

            if(elementos.Count == 1) 
            {
                if(ordenInicio != null) 
                {
                    ordenInicio.Ejecutar();
                }
            }

            if(ordenAlumno != null) 
            {
                ordenAlumno.Ejecutar(com);
            }

            if(elementos.Count == 41) 
            {
                if (ordenFin != null) 
                {
                    ordenFin.Ejecutar();
                }
            }

        }
        public Comparable DesApilar() 
        {
            Comparable aux = elementos[elementos.Count - 1];
            elementos.Remove(elementos[elementos.Count-1]);
            return aux;
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
            this.Apilar(com);
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

        public bool EsVacia ()
        {
            return this.Cuantos() == 0;
        }

        public Iterador CrearIterador()
        {
            return new IteradorDePila(this);
        }

        public List<Comparable> GetElementos()
        {
            return new List<Comparable>(elementos);
        }

        public void setOrdenInicio(IOrdenEnAula1 orden)
        {
            ordenInicio = orden;
        }

        public void setOrdenLlegaAlumno(IOrdenEnAula2 orden)
        {
           ordenAlumno = orden;
        }

        public void setOrdenAulaLlena(IOrdenEnAula1 orden)
        {
            ordenFin = orden; 
        }
    }
}
