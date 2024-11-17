using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__7
{
    public class FabricaDeProfesores : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        { 
            return new Profesor(manejador.NumeroAleatorio(10), manejador.StringAleatorio(20), manejador.NumeroAleatorio(9999999));
        }

        public override Comparable CrearPorTeclado()
        {

            Console.WriteLine("Ingresar datos del nuevo profesor. \n");

            Console.WriteLine("Ingresar nombre del alumno: ");
            string nombre = manejador.StringPorTeclado();

            Console.WriteLine("Ingresar DNI (SIN PUNTOS): ");
            int dni = manejador.NumeroPorTeclado();

            Console.WriteLine("Ingresar antiguedad: ");
            int antiguedad = manejador.NumeroPorTeclado();

            return new Profesor(antiguedad, nombre, dni);
        }

        public override Comparable CrearTomandoDatos()
        {
            throw new NotImplementedException();
        }
    }
}
