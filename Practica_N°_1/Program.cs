using Practica_N__1;
using System;
using System.Xml.Linq;

namespace Practiva_N__1
{
    class Program
    {


        static void Main(string[] args)
        {
            Pila pila = new Pila();
            Cola cola = new Cola();
            ColeccionMultiple multipleCol = new ColeccionMultiple(pila, cola);
            //Llenar(pila);
            //Informar(pila);
            //Llenar(cola);
            //Informar(cola);
            //Informar(multipleCol);
            //LlenarPersonas(pila);
            //LlenarPersonas(cola);
            LlenarAlumnos(pila);
            LlenarAlumnos(cola);
            Informar(multipleCol);
        }

        public static void Llenar(Coleccionable col)
        {
            for (int i = 0; i < 20; i++) 
            {
                Comparable aux = new Numero(i + 1);
                col.Agregar(aux);
            }
        }
        public static void Informar(Coleccionable col) 
        {
            Console.WriteLine(col.Cuantos());
            Console.WriteLine(col.Minimo());
            Console.WriteLine(col.Maximo());
            //Console.WriteLine("Por favor, ingresa un número entero:");
            //No Supe como hacerlo
            //int num = int.Parse(Console.ReadLine());
            //Comparable com = new Numero(num);
            //if (col.Contiene(com)) 
            //{
            //    Console.WriteLine("El elemento leído está en la colección");
            //}
            //else 
            //{
            //    Console.WriteLine("El elemento leído no está en la colección");
            //}
        }

        public static void LlenarPersonas(Coleccionable col) 
        {
            string[] nombres = { "Ana", "Luis", "Carlos", "Maria", "José", "Laura", "Pedro", "Sofía", "Juan", "Isabel",
                                 "Miguel", "Carmen", "David", "Patricia", "Jorge", "Marta", "Francisco", "Lucía", "Antonio", "Claudia" };
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                string nombre = nombres[random.Next(nombres.Length)];
                int dni = random.Next(400000000, 500000000);
                Comparable com = new Persona(nombre, dni);
                col.Agregar(com);
            }
        }

        public static void LlenarAlumnos(Coleccionable col) 
        {
            string[] nombres = { "Ana", "Luis", "Carlos", "Maria", "José", "Laura", "Pedro", "Sofía", "Juan", "Isabel",
                                 "Miguel", "Carmen", "David", "Patricia", "Jorge", "Marta", "Francisco", "Lucía", "Antonio", "Claudia" };
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                string nombre = nombres[random.Next(nombres.Length)];
                int dni = random.Next(400000000, 500000000);
                int legajo = random.Next(2000, 30000);
                int promedio = random.Next(0, 10);
                Comparable com = new Alumno(nombre, dni, legajo, promedio);
                col.Agregar(com);
            }
        }

    }
}
