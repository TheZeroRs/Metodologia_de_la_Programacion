using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__7
{
    public class GeneradorDeDatosAletorios : Manejador
    {
        private Random random;
        private static GeneradorDeDatosAletorios _aleatorio;

        private GeneradorDeDatosAletorios(Manejador manejador) : base(manejador)
        {
            random = new Random();
        }

        public static GeneradorDeDatosAletorios getInstancia(Manejador manejador)
        {
            return _aleatorio = new GeneradorDeDatosAletorios(manejador);
        }

        public override int NumeroAleatorio(int max) 
        {
            return random.Next(0, max + 1);
        }

        public override string StringAleatorio(int cant) 
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            StringBuilder stringBuilder = new StringBuilder(cant);

            for (int i = 0; i < cant; i++) 
            {
                stringBuilder.Append(chars[random.Next(chars.Length)]);
            }
            return stringBuilder.ToString();

        }
    }
}
