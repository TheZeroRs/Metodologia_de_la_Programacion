using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__7
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            Numero numero = new Numero(manejador.NumeroAleatorio(999999999));
            return numero;
        }

        public override Comparable CrearPorTeclado()
        {
            Console.Write("Ingrese un numero: ");
            int n = manejador.NumeroPorTeclado();
            return new Numero(n);
        }
    }
}
