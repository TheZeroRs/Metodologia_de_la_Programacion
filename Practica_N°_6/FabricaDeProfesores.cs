using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__6
{
    public class FabricaDeProfesores : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            GeneradorDeDatosAleaorios aleaorio = new GeneradorDeDatosAleaorios();
            return new Profesor(aleaorio.NumeroAleatorio(10), aleaorio.StringAleatorio(20), aleaorio.NumeroAleatorio(9999999));
        }

        public override Comparable CrearPorTeclado()
        {

            Console.WriteLine("Ingresar datos del nuevo profesor. \n");

            Console.WriteLine("Ingresar nombre del alumno: ");
            string nombre = lector.StringPorTeclado();

            Console.WriteLine("Ingresar DNI (SIN PUNTOS): ");
            int dni = lector.NumeroPorTeclado();

            Console.WriteLine("Ingresar antiguedad: ");
            int antiguedad = lector.NumeroPorTeclado();

            return new Profesor(antiguedad, nombre, dni);
        }
    }
}
