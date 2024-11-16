using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__6
{
    public interface IObservado
    {
        void AgregarObservador(IObservador o);
        void QuitarObservador(IObservador o);
        void Notificar();
    }
}
