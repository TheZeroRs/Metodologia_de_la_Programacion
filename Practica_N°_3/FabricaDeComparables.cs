using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__3
{
    public abstract class FabricaDeComparables
    {

        protected GeneradorDeDatosAleaorios generador;
        protected LectorDeDatos lector;

        public FabricaDeComparables()
        {
            this.generador = new GeneradorDeDatosAleaorios();
            this.lector = new LectorDeDatos();
        }

        public static Comparable CrearAleatorio(int opc) 
        {
            FabricaDeComparables fabrica = null;
            switch (opc)
            {
                case 1:
                    fabrica = new FabricaDeAlumnos();
                    break;
                case 2:
                    //fabrica = new FabricaDeProfesores();
                    break;
            }
            return fabrica.CrearAleatorio();
        }

        public abstract Comparable CrearAleatorio();


        public static Comparable CrearPorTeclado(int opc)
        {
            FabricaDeComparables fabrica = null;
            switch (opc)
            {
                case 1:
                    fabrica = new FabricaDeAlumnos();
                    break;
                case 2:
                    //fabrica = new FabricaDeProfesores();
                    break;
            }
            return fabrica.CrearPorTeclado();
        }

        public abstract Comparable CrearPorTeclado();

    }


}
