﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__6
{
    public class FabricaDeAlumnosCompuestos : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            return new AlumnoCompuesto();
        }

        public override Comparable CrearPorTeclado()
        {
            return new AlumnoCompuesto();
        }
    }
}
