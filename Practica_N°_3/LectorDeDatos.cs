using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__3
{
    public class LectorDeDatos
    {
       public int NumeroPorTeclado()
       {
            int numero;
            while(true) 
            {
                Console.Write("Ingese un numero: ");
                string n = Console.ReadLine();
                if (int.TryParse(n, out numero) ) 
                { 
                    return numero; 
                }
                else 
                {
                    Console.WriteLine("Ingrese un numero, no otra cosa.");
                }
            }
       }

       public string StringPorTeclado() 
        {
            Console.WriteLine("Ingrese un texto: ");
            return Console.ReadLine();
        }
        

    }
}
