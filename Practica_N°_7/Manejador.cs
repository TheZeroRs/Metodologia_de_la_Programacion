using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__7
{
    public abstract class Manejador
    {
        Manejador sucesor = null;

        public Manejador(Manejador sucesor)
        {
            this.sucesor = sucesor;
        }

        virtual public int NumeroAleatorio(int max)
        {
            if(sucesor != null)
            {
               return sucesor.NumeroAleatorio(max);
            }
            throw new InvalidOperationException("No se puede manejar la solicitud para 'NumeroAleatorio'.");
        }

        virtual public string StringAleatorio(int cant)
        {
            if (sucesor != null)
            {
                return sucesor.StringAleatorio(cant);
            }
            throw new InvalidOperationException("No se puede manejar la solicitud para 'StringAleatorio'.");
        }
        virtual public int NumeroPorTeclado()
        {
            if (sucesor != null)
            {
                return sucesor.NumeroPorTeclado();
            }
            throw new InvalidOperationException("No se puede manejar la solicitud para 'NumeroPorTeclado'.");
        }
        virtual public string StringPorTeclado()
        {
            if (sucesor != null)
            {
                return sucesor.StringPorTeclado();
            }
            throw new InvalidOperationException("No se puede manejar la solicitud para 'StringPorTeclado'.");
        }
        virtual public double numeroDesdeArchivo(double max)
        {
            if (sucesor != null)
            {
                return sucesor.numeroDesdeArchivo(max);
            }
            throw new InvalidOperationException("No se puede manejar la solicitud para 'NumeroDesdeArchivo'.");
        }
        virtual public string stringDesdeArchivo(int cant)
        {
            if (sucesor != null)
            {
                return sucesor.stringDesdeArchivo(cant);
            }
            throw new InvalidOperationException("No se puede manejar la solicitud para 'StringDesdeArchivo'.");
        }

    }
}
