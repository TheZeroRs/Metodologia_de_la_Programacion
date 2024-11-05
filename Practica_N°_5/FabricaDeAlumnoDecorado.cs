using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__5
{
    public class FabricaDeAlumnoDecorado : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            IAlumno alumno, deco1, deco2, deco3, deco4, deco5;
            alumno = (IAlumno)FabricaDeComparables.CrearAleatorio(1);
            deco1 = new DecoradorAlumnoLegajo(alumno);
            deco2 = new DecoradorAlumnoNotaLetras(deco1);
            deco3 = new DecoradorAlumnoPromo(deco2);
            deco4 = new DecoradorAlumnoOrden(deco3, 1);
            deco5 = new DecoradorAlumnoAsteriscos(deco4);

            return (Alumno)deco5;
        }

        public override Comparable CrearPorTeclado()
        {
            IAlumno alumno, deco1, deco2, deco3, deco4, deco5;
            alumno = (IAlumno)FabricaDeComparables.CrearPorTeclado(1);
            deco1 = new DecoradorAlumnoLegajo(alumno);
            deco2 = new DecoradorAlumnoNotaLetras(deco1);
            deco3 = new DecoradorAlumnoPromo(deco2);
            deco4 = new DecoradorAlumnoOrden(deco3, 1);
            deco5 = new DecoradorAlumnoAsteriscos(deco4);
            return (Alumno)deco5;
        }
    }
}
