﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__1
{
    interface Comparable
    {
        bool SosIgual(Comparable com);
        bool SosMenor(Comparable com);
        bool SosMayor(Comparable com);
    }
}
