using MetodologíasDeProgramaciónI;
using System;

namespace Practica_N__5
{
    class Program
    {

        static void Main(string[] args)
        {

            Teacher teacher = new Teacher();
            int orden = 1;
            for (int i = 0; i < 10; i++)
            {
                Comparable alumno = FabricaDeComparables.CrearAleatorio(1);
                AlumnoAdaptado alumnoAdaptado = new AlumnoAdaptado((Alumno)alumno);
                IAlumno adaptado = (IAlumno)alumnoAdaptado;

                adaptado = new DecoradorAlumnoLegajo(adaptado);
                adaptado = new DecoradorAlumnoNotaLetras(adaptado);
                adaptado = new DecoradorAlumnoPromo(adaptado);
                adaptado = new DecoradorAlumnoOrden(adaptado, orden);
                adaptado = new DecoradorAlumnoAsteriscos(adaptado);

                //teacher.goToClass((AlumnoAdaptado)adaptado);
                Console.WriteLine(adaptado.mostrarCalificacion());
                orden++;
            }

            for (int i = 0; i < 10; i++)
            {
                Comparable alumno = FabricaDeComparables.CrearAleatorio(3);
                AlumnoAdaptado alumnoAdaptado = new AlumnoAdaptado((AlumnoMuyEstudioso)alumno);
                IAlumno adaptado = (IAlumno)alumnoAdaptado;

                adaptado = new DecoradorAlumnoLegajo(adaptado);
                adaptado = new DecoradorAlumnoNotaLetras(adaptado);
                adaptado = new DecoradorAlumnoPromo(adaptado);
                adaptado = new DecoradorAlumnoOrden(adaptado, orden);
                adaptado = new DecoradorAlumnoAsteriscos(adaptado);

                //teacher.goToClass((AlumnoAdaptado)asteriscos);
                Console.WriteLine(adaptado.mostrarCalificacion());
                orden++;
            }
            teacher.teachingAClass();
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