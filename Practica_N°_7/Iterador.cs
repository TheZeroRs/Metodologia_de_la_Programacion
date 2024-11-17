using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__7
{
    public interface Iterador
    {
        void Primero();
        void Siguiente();
        bool Fin();
        Comparable Actual();
    } 
}