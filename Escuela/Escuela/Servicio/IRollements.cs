﻿using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Servicio
{
    public interface IRollements
    {
        List<Enrollment> UnionDeTablas();
    }
}
