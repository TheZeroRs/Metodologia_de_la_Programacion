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
            GeneradorDeDatosAleaorios aleatorio = new GeneradorDeDatosAleaorios();
            Numero numero = new Numero(aleatorio.NumeroAleatorio(999999999));
            return numero;
        }

        public override Comparable CrearPorTeclado()
        {
            Console.Write("Ingrese un numero: ");
            int n = int.Parse(Console.ReadLine());
            return new Numero(n);
        }
    }
}
