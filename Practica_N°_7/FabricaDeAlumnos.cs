using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__7
{
    public class FabricaDeAlumnos: FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            EstrategiaDeComparacion estrategia = new ComPorLegajo();
            return new Alumno(manejador.StringAleatorio(5), manejador.NumeroAleatorio(1000000), manejador.NumeroAleatorio(1000), manejador.NumeroAleatorio(10), estrategia, manejador.NumeroAleatorio(10));
        }

        public override Comparable CrearPorTeclado() 
        {
            Console.Write("Ingresar datos del nuevo alumno. \n");

            Console.Write("Ingresar nombre del alumno: ");
            string nombre = manejador.StringPorTeclado();

            Console.Write("Ingresar DNI (SIN PUNTOS): ");
            int dni = manejador.NumeroPorTeclado();

            Console.Write("Ingresar legajo: ");
            int legajo = manejador.NumeroPorTeclado();

            Console.Write("Ingresar promedio: ");
            int promedio = manejador.NumeroPorTeclado();

            Console.Write("Ingrese calificacion: ");
            int calificacion = manejador.NumeroPorTeclado();

            Console.Write("Elegir una estrategia de comparacion: \n" +
                "1- Por legajo \n" +
                "2- Por dni \n" +
                "3- Por nombre \n" +
                "4- Por promedio");
            int op = int.Parse(Console.ReadLine());
            EstrategiaDeComparacion estrategia = new ComPorLegajo();
            switch (op) 
            {
                case 1:
                     estrategia = new ComPorLegajo();
                    break;
                case 2:
                     estrategia = new ComPorDNI();
                    break;
                case 3:
                     estrategia = new ComPorNombre();
                    break;
                case 4:
                     estrategia = new ComPorPromedio();
                    break;
            }

           return new Alumno(nombre, dni, legajo, promedio, estrategia, calificacion);
        }

        public override Comparable CrearTomandoDatos()
        {
            EstrategiaDeComparacion estrategia = new ComPorLegajo();
            return new Alumno(manejador.stringDesdeArchivo(5), (int)manejador.numeroDesdeArchivo(1000000), (int)manejador.numeroDesdeArchivo(1000), (int)manejador.numeroDesdeArchivo(10),estrategia, (int)manejador.numeroDesdeArchivo(10));
        }
    }
}