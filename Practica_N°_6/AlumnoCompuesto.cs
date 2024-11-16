using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__6
{
    public class AlumnoCompuesto : IAlumno, Comparable
    {
        private List<IAlumno> _alumnos = new List<IAlumno>();

        public void AgregarAlumno(IAlumno alumno)
        {
            _alumnos.Add(alumno);
        }

        public void QuitarAlumno(IAlumno alumno)
        {
            _alumnos.Remove(alumno);
        }


        public string GetNombre()
        {
            return string.Join(", ", _alumnos.Select(a => a.GetNombre()));
        }

        public int responderPregunta(int pregunta)
        {
            var respuestas = _alumnos.GroupBy(res  => res.responderPregunta(pregunta)).OrderByDescending(g => g.Count()).ToList();

            var respuestaMasVotadas = respuestas.Where(g => g.Count() == respuestas.First().Count()).ToList();
            return respuestaMasVotadas[new Random().Next(respuestaMasVotadas.Count)].Key;
        }

        public void setCalificacion(int calificacion)
        {
            foreach(IAlumno oneAlumno in _alumnos)
            {
                oneAlumno.setCalificacion(calificacion);
            }
        }

        public string mostrarCalificacion()
        {
           var calificacionGrupo = new StringBuilder();

            foreach (IAlumno oneAlumno in _alumnos)
            {
                calificacionGrupo.AppendLine(oneAlumno.mostrarCalificacion());
            }
            return calificacionGrupo.ToString();

        }

        public int getLegajo()
        {
            return _alumnos.FirstOrDefault()?.getLegajo() ?? 0;
        }

        public bool SosIgual(Comparable com)
        {
            return _alumnos.Any(igual => igual.SosIgual(com));
        }

        public bool SosMayor(Comparable com)
        {
            return _alumnos.All(max => max.SosMayor(com));
        }

        public bool SosMenor(Comparable com)
        {
            return _alumnos.All(min => min.SosMenor(com));
        }

        public int getCalificacion()
        {
            throw new NotImplementedException();
        }

        public EstrategiaDeComparacion getEstrategia()
        {
            throw new NotImplementedException();
        }

        public int getPromedio()
        {
            throw new NotImplementedException();
        }

        

        public void setEstrategia(EstrategiaDeComparacion estrategia)
        {
            throw new NotImplementedException();
        }

        public void setLegajo(int legajo)
        {
            throw new NotImplementedException();
        }

        public void SetNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public void setPromedio(int promedio)
        {
            throw new NotImplementedException();
        }
    }
}
