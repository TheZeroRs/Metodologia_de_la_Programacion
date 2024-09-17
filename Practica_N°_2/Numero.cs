using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__2
{
    public class Numero : Comparable
    {
        private int valor;
        public Numero(int valor) 
        {
            this.valor = valor;
        }

        public int GetValor() 
        { 
            return this.valor;
        }

        public bool SosIgual(Comparable com)
        {
            if(this.valor == ((Numero)com).GetValor()) 
            {
                return true;
            }
            return false;
        }

        public bool SosMayor(Comparable com)
        {
            if (this.valor < ((Numero)com).GetValor()) 
            {
                return true;
            }
            return false;
        }

        public bool SosMenor(Comparable com)
        {
            if (this.valor > ((Numero)com).GetValor())
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return this.valor.ToString();
        }
    }
}
