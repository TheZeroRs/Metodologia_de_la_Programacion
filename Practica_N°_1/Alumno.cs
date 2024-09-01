using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__1
{
    class Alumno : Persona
    {
        int legajo;
        int promedio;
        public Alumno(string nombre, int dni, int legajo, int promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public int getLegajo() 
        {
            return legajo;
        }  
        
        public int getPromedio() 
        {
            return promedio;
        }
        public override bool SosMenor(Comparable com) 
        {
            if (this.legajo > ((Alumno)com).getLegajo())
            {
                return true;
            }
            return false;
        }
        public override bool SosMayor(Comparable com)
        {
            if (this.legajo < ((Alumno)com).getLegajo())
            {
                return true;
            }
            return false;
        }
        public override bool SosIgual(Comparable com)
        {
            if (this.legajo == ((Alumno)com).getLegajo())
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return this.legajo.ToString();
        }
    }
}
