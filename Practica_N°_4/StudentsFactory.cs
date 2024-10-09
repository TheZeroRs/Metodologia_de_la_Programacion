using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__4
{
    public class StudentsFactory : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            throw new NotImplementedException();
        }

        public override Comparable CrearPorTeclado()
        {
            throw new NotImplementedException();
        }
    }
}
