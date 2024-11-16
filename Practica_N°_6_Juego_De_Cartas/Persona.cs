using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__6_Juego_De_Cartas
{
    public class Persona
    {
        string nombre;
        public Persona(string nombre) 
        {
            this.nombre = nombre;
        }
        public string GetNombre() 
        {
            return this.nombre;
        }

        public void SetNombre(string nombre) 
        {
            this.nombre = nombre;
        }

    }
}
