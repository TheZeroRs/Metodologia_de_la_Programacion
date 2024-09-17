using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__2
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
            if (this.dni > ((Persona)com).GetDni()) 
            {
                return true;
            }
            return false;
        }

        public virtual bool SosMayor(Comparable com) 
        {
            if (this.dni < ((Persona)com).GetDni())
            {
                return true;
            }
            return false;
        }

        public virtual bool SosIgual(Comparable com) 
        {
            if (this.dni == ((Persona)com).GetDni())
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return this.dni.ToString();
        }


    }
}
