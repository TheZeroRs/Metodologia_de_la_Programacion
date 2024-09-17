using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__2
{
    public class Alumno : Persona
    {
        int legajo;
        int promedio;
        EstrategiaDeComparacion estrategia;

        public Alumno(string nombre, int dni, int legajo, int promedio, EstrategiaDeComparacion estrategia) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            this.estrategia = estrategia;
        }

        public int getLegajo() 
        {
            return legajo;
        }  
        
        public int getPromedio() 
        {
            return promedio;
        }

        public void setEstrategia(EstrategiaDeComparacion estrategia)
        {
            this.estrategia = estrategia;
        }

        public override bool SosIgual(Comparable com)
        {
            return this.estrategia.SosIgual(this, ((Alumno)com));
        }

        public override bool SosMenor(Comparable com)
        {
           return this.estrategia.SosMenor(this, ((Alumno)com));
        }

        public override bool SosMayor(Comparable com)
        {
           return this.estrategia.SosMayor(this, ((Alumno)com));
        }

        public override string ToString()
        {
            return this.legajo.ToString();
        }
    }
}
