using MetodologíasDeProgramaciónI;
using System;

namespace Practica_N__7
{
    class Program
    {

        static void Main(string[] args)
        {
            Pila pila = new Pila();
            Aula aula = new Aula();
            pila.setOrdenInicio(new OrdenInicio(aula));
            pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
            pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
            Llenar(pila, 1);
            Llenar(pila, 3);
            Llenar(pila, 6);
        }



        public static void Llenar(Coleccionable col, int opcion)
        {
            if (opcion == 6)
            {
                AlumnoCompuesto compuesto = (AlumnoCompuesto)FabricaDeComparables.CrearAleatorio(6);
                for (int i = 0; i < 5; i++)
                {
                    Comparable aux;
                    Comparable proxy = FabricaDeComparables.CrearAleatorio(4);
                    compuesto.AgregarAlumno((IAlumno)proxy);
                }
                col.Agregar(compuesto);
            }


            if (opcion != 6)
            {
                for (int i = 0; i < 20; i++)
                {
                    Comparable aux = FabricaDeComparables.CrearAleatorio(opcion);
                    col.Agregar(aux);
                }
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