﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__6
{
    public interface IOrdenable
    {
        void setOrdenInicio(IOrdenEnAula1 orden);
        void setOrdenLlegaAlumno(IOrdenEnAula2 orden);
        void setOrdenAulaLlena(IOrdenEnAula1 orden);
    }
}
