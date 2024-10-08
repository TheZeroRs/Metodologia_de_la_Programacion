using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__3
{
    public class FabricaDeAlumnos: FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            EstrategiaDeComparacion estrategia = new ComPorLegajo();
            return new Alumno(generador.StringAleatorio(5), generador.NumeroAleatorio(1000000),generador.NumeroAleatorio(1000),generador.NumeroAleatorio(10), estrategia);
        }

        public override Comparable CrearPorTeclado() 
        {
            Console.Write("Ingresar datos del nuevo alumno. \n");

            Console.Write("Ingresar nombre del alumno: ");
            string nombre = lector.StringPorTeclado();

            Console.Write("Ingresar DNI (SIN PUNTOS): ");
            int dni = lector.NumeroPorTeclado();

            Console.Write("Ingresar legajo: ");
            int legajo = lector.NumeroPorTeclado();

            Console.Write("Ingresar promedio: ");
            int promedio = lector.NumeroPorTeclado();

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

           return new Alumno(nombre, dni, legajo, promedio, estrategia);
        }
    }
}