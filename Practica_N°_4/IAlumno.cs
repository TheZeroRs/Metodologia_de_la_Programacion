using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__4
{
    public interface IAlumno
    {
        
        //Legajo
        int getLegajo();
        void setLegajo(int legajo);
        //Promedio
        int getPromedio();
        void setPromedio(int promedio);
        //Calificacion
        int getCalificacion();
        void setCalificacion(int calificacion);
        //Estrategia
        void setEstrategia(EstrategiaDeComparacion estrategia);
        EstrategiaDeComparacion getEstrategia();
        //Metodos 
        string mostrarCalificacion();
        int responderPregunta(int pregunta);

    }
}
