using Practica_N__3;
using System;
using System.Xml.Linq;

namespace Practiva_N__3
{
    class Program
    {


        static void Main(string[] args)
        {
            Pila pila = new Pila();
            Cola cola = new Cola();

            Console.WriteLine("Ingrese una opcion: \n" +
                "1- Llenar alumnos");

            int opcion = int.Parse(Console.ReadLine());

            Llenar(pila, opcion);
            Llenar(cola, opcion);

            ColeccionMultiple multipleCol = new ColeccionMultiple(pila, cola);

            ImprimirELementos(pila);
            ImprimirELementos(cola);
            EstrategiaDeComparacion estrategia = new ComPorLegajo();
            CambiarEstrategia(pila, estrategia);

        }

        public static void Llenar(Coleccionable col, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable aux = FabricaDeComparables.CrearAleatorio(opcion);
                col.Agregar(aux);
            }
        }

        public static void Informar(Coleccionable col, int opcion)
        {
            Console.WriteLine(col.Cuantos());
            Console.WriteLine(col.Minimo());
            Console.WriteLine(col.Maximo());
            Comparable com = FabricaDeComparables.CrearPorTeclado(opcion);

            if (col.Contiene(com)) 
            {
                Console.WriteLine("El elemento leido esta en la coleccion.");
            }
            else 
            {
                Console.WriteLine("El elemento leido no esta en la coleccion");
            }

        }


        public static void ImprimirELementos(Coleccionable col)
        {
            Iterador ite = col.CrearIterador();
            ite.Primero();
            while (!ite.Fin())
            {
                Console.WriteLine("El elemento actual es: " + ite.Actual());
                ite.Siguiente();
            }
        }

        public static void CambiarEstrategia(Coleccionable col, EstrategiaDeComparacion estrategia)
        {
            Iterador ite = col.CrearIterador();
            ite.Primero();
            while (!ite.Fin())
            {
                if (ite.Actual() is Alumno alumno)
                {
                    alumno.setEstrategia(estrategia);
                }
                ite.Siguiente();
            }
        }
    }
}
