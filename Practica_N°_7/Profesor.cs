using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__7
{
    internal class Profesor: Persona, IObservado
    {
        int antiguedad;
        List<IObservador> observadores;
        bool hablando;

        public Profesor(int antiguedad, string nombre, int dni): base(nombre, dni)
        {
            this.antiguedad = antiguedad;
            observadores = new List<IObservador>();
            this.hablando = false;
        }

        public void HablarAlaClase() 
        {
            Console.WriteLine("Hablando de algun tema.");
            this.hablando= true;
            Notificar();
        }

        public void EscribirEnElPizarron() 
        {
            Console.WriteLine("Escribiendo en el pizarron.");
            this.hablando= false;
            Notificar();
        }

        public int GetAntiguedad()
        {
            return this.antiguedad;
        }

        public override bool SosIgual(Comparable com)
        {
            return this.antiguedad == ((Profesor)com).GetAntiguedad();
        }

        public override bool SosMenor(Comparable com)
        {
             return this.antiguedad < ((Profesor)com).GetAntiguedad();
        }

        public override bool SosMayor(Comparable com)
        {
            return this.antiguedad > ((Profesor)com).GetAntiguedad();
        }

        public void AgregarObservador(IObservador o)
        {
            observadores.Add(o);
        }

        public void QuitarObservador(IObservador o)
        {
           observadores.Remove(o);
        }

        public void Notificar()
        {
            foreach(IObservador obs in observadores) 
            {
                obs.Actualizar(this);
            }
        }
        public bool IsHablando() 
        {
            return this.hablando;
        }
    }
}
