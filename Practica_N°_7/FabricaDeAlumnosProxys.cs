﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__7
{
    public class FabricaDeAlumnosProxys : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            return new AlumnoProxy(manejador.StringAleatorio(5),1); 
        }

        public override Comparable CrearPorTeclado()
        {
            Console.Write("Ingresar datos del nuevo alumno. \n");

            Console.Write("Ingresar nombre del alumno: ");
            string nombre = manejador.StringPorTeclado();

            return new AlumnoProxy(nombre, 1);
        }

        public override Comparable CrearTomandoDatos()
        {
            return new AlumnoProxy(manejador.stringDesdeArchivo(5),1);
        }
    }
}
