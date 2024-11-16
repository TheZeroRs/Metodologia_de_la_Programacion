using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__6
{
    public class AlumnoProxy: IAlumno, Comparable
    {
        private IAlumno alumnoReal = null;
        private string nombre;
        private int queCrear;

        public AlumnoProxy(string nombre, int queCrear) 
        {
            this.nombre = nombre;
            this.queCrear = queCrear;
        }

        public string GetNombre() 
        {
            return this.nombre; 
        }

        public int responderPregunta(int pregunta) 
        {
            if(alumnoReal == null) 
            {
                Console.WriteLine("Se crea un alumno real");
                alumnoReal = (IAlumno)FabricaDeComparables.CrearAleatorio(queCrear);
                alumnoReal.SetNombre(this.nombre);
            }
            return alumnoReal.responderPregunta(pregunta);
        }

        public string mostrarCalificacion() 
        {
            return alumnoReal.mostrarCalificacion();
        }

        public int getLegajo()
        {
            return alumnoReal.getLegajo();
        }

        public void setLegajo(int legajo)
        {
            throw new NotImplementedException();
        }

        public int getPromedio()
        {
            throw new NotImplementedException();
        }

        public void setPromedio(int promedio)
        {
            throw new NotImplementedException();
        }

        public int getCalificacion()
        {
            throw new NotImplementedException();
        }

        public void setCalificacion(int calificacion)
        {
            alumnoReal.setCalificacion(calificacion);
        }

        public void setEstrategia(EstrategiaDeComparacion estrategia)
        {
            throw new NotImplementedException();
        }

        public EstrategiaDeComparacion getEstrategia()
        {
            throw new NotImplementedException();
        }

        public bool SosIgual(Comparable com)
        {
            throw new NotImplementedException();
        }

        public bool SosMenor(Comparable com)
        {
            throw new NotImplementedException();
        }

        public bool SosMayor(Comparable com)
        {
            throw new NotImplementedException();
        }

        public void SetNombre(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
