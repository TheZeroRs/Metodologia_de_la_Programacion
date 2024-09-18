using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__3
{
    public class Persona : Comparable
    {
        string nombre;
        int dni;
        public Persona(string nombre, int dni) 
        {
            this.nombre = nombre;
            this.dni = dni;
        }
        public string GetNombre() 
        {
            return this.nombre;
        }
        public int GetDni() 
        {
            return this.dni;
        }

        public virtual bool SosMenor(Comparable com) 
        {
            return this.dni > ((Persona)com).GetDni();
        }

        public virtual bool SosMayor(Comparable com) 
        {
            return this.dni < ((Persona)com).GetDni();
        }

        public virtual bool SosIgual(Comparable com) 
        {
            return this.dni == ((Persona)com).GetDni();
        }
        public override string ToString()
        {
            return this.dni.ToString();
        }


    }
}
