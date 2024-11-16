using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__6
{
    public class Alumno : Persona, IObservador, IAlumno
    {
        int legajo;
        int promedio;
        EstrategiaDeComparacion estrategia;
        int calificacion;

        public Alumno(string nombre, int dni, int legajo, int promedio, EstrategiaDeComparacion estrategia, int calificacion) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            this.estrategia = estrategia;
            this.calificacion = calificacion;
        }

        public int getLegajo() 
        {
            return legajo;
        }  
        public void setLegajo(int legajo)
        {
            this.legajo = legajo;
        }
        
        public int getPromedio() 
        {
            return promedio;
        }
        public void setPromedio(int promedio)
        {
            this.promedio = promedio;
        }

        public EstrategiaDeComparacion getEstrategia()
        {
            return this.estrategia;
        }
        public void setEstrategia(EstrategiaDeComparacion estrategia)
        {
            this.estrategia = estrategia;
        }
        
        public int getCalificacion() 
        {
            return calificacion;
        }
        
        public void setCalificacion(int calificacion) 
        {
            this.calificacion = calificacion;
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

        public virtual int responderPregunta(int pregunta) 
        {
            Random random = new Random();
            int indice = random.Next(1, 4);
            return indice;
        }

        public virtual string mostrarCalificacion() 
        {
            return  this.GetNombre() + "       " + this.getCalificacion();
        }
    }
}
