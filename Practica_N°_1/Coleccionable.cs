using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__1
{
    interface Coleccionable
    {
        int Cuantos();
        Comparable Minimo();
        Comparable Maximo();
        void Agregar(Comparable com);
        bool Contiene(Comparable com);
    }
}
