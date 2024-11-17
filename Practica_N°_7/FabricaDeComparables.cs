using ObtencionDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__7
{
    public abstract class FabricaDeComparables
    {

        protected Manejador manejador;
        

        public FabricaDeComparables()
        {
            this.manejador = CrearCadenaDeResponsabilidades();
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
                    fabrica = new FabricaDeProfesores();
                    break;
                case 3:
                    fabrica = new FabricaDeAlumnosEstudiosos();
                    break;
                case 4:
                    fabrica = new FabricaDeAlumnosProxys();
                    break;
                case 5:
                    fabrica = new FabricaDeAlumnoDecorado();
                    break;
                case 6:
                    fabrica = new FabricaDeAlumnosCompuestos();
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

        public static Manejador CrearCadenaDeResponsabilidades()
        {
            Manejador manejador = new LectorDeArchivos(null);
            manejador = new GeneradorDeDatosAleaorios(manejador);
            manejador = new LectorDeDatos(manejador);
            return manejador;
        }

    }


}
