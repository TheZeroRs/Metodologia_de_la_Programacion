using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__7
{
    public class LectorDeDatos: Manejador
    {
       private static LectorDeDatos _intancia;
       private LectorDeDatos(Manejador manejador) : base(manejador)
       {

       }

        public static LectorDeDatos getInstancia(Manejador manejador)
        {
            if (_intancia == null) 
            {
                return _intancia = new LectorDeDatos(manejador);
            }
            return _intancia;
            
        }

        public override int NumeroPorTeclado()
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

       public override string StringPorTeclado() 
        {
            Console.WriteLine("Ingrese un texto: ");
            return Console.ReadLine();
        }
        

    }
}
