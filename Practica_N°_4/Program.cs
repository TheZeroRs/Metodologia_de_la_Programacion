using MetodologíasDeProgramaciónI;
using System;

namespace Practica_N__4 
{
    class Program
    {

        static void Main(string[] args)
        {
                Student student;
                Teacher teacher = new Teacher();
                IAlumno alumno, muyEstudioso, deco1, deco2, deco3, deco4, deco5;
            int cont = 0;
                for (int i = 0; i < 10; i++)
                {
                    alumno = (IAlumno)FabricaDeComparables.CrearAleatorio(1);
                    deco1 = new DecoradorAlumnoLegajo(alumno);
                    deco2 = new DecoradorAlumnoNotaLetras(deco1);
                    deco3 = new DecoradorAlumnoPromo(deco2);
                    deco4 = new DecoradorAlumnoOrden(deco3, cont);
                    deco5 = new DecoradorAlumnoAsteriscos(deco4);

                    student = new AlumnoAdaptado(deco5);

                    teacher.goToClass(student);
                cont++;
                }

                for (int i = 0; i < 10; i++)
                {
                    muyEstudioso = (IAlumno)FabricaDeComparables.CrearAleatorio(3);


                    deco1 = new DecoradorAlumnoLegajo(muyEstudioso);
                    deco2 = new DecoradorAlumnoNotaLetras(deco1);
                    deco3 = new DecoradorAlumnoPromo(deco2);
                    deco4 = new DecoradorAlumnoOrden(deco3, cont);
                    deco5 = new DecoradorAlumnoAsteriscos(deco4);

                    student = new AlumnoAdaptado(deco5);
                    teacher.goToClass(student);
                cont++;
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