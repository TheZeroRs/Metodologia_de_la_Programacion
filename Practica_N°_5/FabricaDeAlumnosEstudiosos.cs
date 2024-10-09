using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__5
{
    public class FabricaDeAlumnosEstudiosos : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            GeneradorDeDatosAleaorios aleatorios = new GeneradorDeDatosAleaorios();
            EstrategiaDeComparacion estrategia = new ComPorLegajo();
            return new AlumnoMuyEstudioso(aleatorios.StringAleatorio(5), aleatorios.NumeroAleatorio(1000000), aleatorios.NumeroAleatorio(1000), aleatorios.NumeroAleatorio(10), estrategia, aleatorios.NumeroAleatorio(10));
        }

        public override Comparable CrearPorTeclado()
        {
            Console.Write("Ingresar datos del nuevo alumno. \n");

            Console.Write("Ingresar nombre del alumno: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresar DNI (SIN PUNTOS): ");
            int dni = int.Parse(Console.ReadLine());

            Console.Write("Ingresar legajo: ");
            int legajo = int.Parse(Console.ReadLine());

            Console.Write("Ingresar promedio: ");
            int promedio = int.Parse(Console.ReadLine());

            Console.Write("Elegir una estrategia de comparacion: \n" +
                "1- Por legajo \n" +
                "2- Por dni \n" +
                "3- Por nombre \n" +
                "4- Por promedio \n");
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
            Console.Write("Ingresar calificacion: ");
            int calificacion = int.Parse(Console.ReadLine());

            return new AlumnoMuyEstudioso(nombre, dni, legajo, promedio, estrategia, calificacion);
        }
    }
}
