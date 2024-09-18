using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__3
{
    public class Alumno : Persona, IObservador
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

        public void PrestarAtencion()
        {
            Console.WriteLine("Prestando atencion.");
        }

        public void Distraerse() 
        {
            string[] distracciones = new string[] 
            {
                "Mirando el celular",
                "Dibujando en el margen de la carpeta",
                "Tirando aviones de papel"
            };

            Random random = new Random();
            int indice = random.Next(distracciones.Length);
            Console.WriteLine(distracciones[indice]);
        }

        public void Actualizar(IObservado o)
        {
            if(((Profesor)o).IsHablando())
            {
                PrestarAtencion();
            }
            else 
            {
                Distraerse();
            }
        }
    }
}
