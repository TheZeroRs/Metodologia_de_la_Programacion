using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__5
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            Numero numero = new Numero(generador.NumeroAleatorio(999999999));
            return numero;
        }

        public override Comparable CrearPorTeclado()
        {
            Console.Write("Ingrese un numero: ");
            int n = lector.NumeroPorTeclado();
            return new Numero(n);
        }
    }
}
