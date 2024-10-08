using MetodologíasDeProgramaciónI;
using System;

namespace Practica_N__4 
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
                AlumnoAdaptado adaptado = new AlumnoAdaptado((Alumno)alumno);
                IAlumno alu = adaptado as IAlumno;
                alu = new DecoradorAlumnoLegajo(alu);
                alu = new DecoradorAlumnoNotaLetras(alu);
                alu = new DecoradorAlumnoPromo(alu);
                alu = new DecoradorAlumnoOrden(alu, orden);
                alu = new DecoradorAlumnoAsteriscos(alu);

                teacher.goToClass(adaptado);
                Console.WriteLine(alu.mostrarCalificacion());
                orden++;
            }

            for (int i = 0; i < 10; i++)
            {
                //Comparable alumno = FabricaDeComparables.CrearAleatorio(3);
                //AlumnoAdaptado adaptado = new AlumnoAdaptado((AlumnoMuyEstudioso)alumno);
                //IAlumno legajo = new DecoradorAlumnoLegajo(adaptado);
                //IAlumno notas = new DecoradorAlumnoNotaLetras(legajo);
                //IAlumno promo = new DecoradorAlumnoPromo(notas);
                //IAlumno ordenAlumno = new DecoradorAlumnoOrden(promo, orden);
                //IAlumno asteriscos = new DecoradorAlumnoAsteriscos(ordenAlumno);
                //teacher.goToClass((AlumnoAdaptado)asteriscos);
                //orden++;
            }
            teacher.teachingAClass();

            Comparable a = FabricaDeComparables.CrearAleatorio(1);

            Alumno alum = a as Alumno;

            Console.WriteLine (alum.mostrarCalificacion());

            
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