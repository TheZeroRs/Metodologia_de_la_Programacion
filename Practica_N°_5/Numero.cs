using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__5
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
            return this.valor == ((Numero)com).GetValor();
         
        }

        public bool SosMayor(Comparable com)
        {
            return this.valor < ((Numero)com).GetValor();
            
        }

        public bool SosMenor(Comparable com)
        {
            return this.valor > ((Numero)com).GetValor();
            
        }
        public override string ToString()
        {
            return this.valor.ToString();
        }
    }
}
