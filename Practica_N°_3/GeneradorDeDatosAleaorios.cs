using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__3
{
    public class GeneradorDeDatosAleaorios
    {
        private Random random;

        public GeneradorDeDatosAleaorios()
        {
            random = new Random();
        }

        public int NumeroAleatorio(int max) 
        {
            return random.Next(0, max + 1);
        }

        public string StringAleatorio(int cant) 
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
