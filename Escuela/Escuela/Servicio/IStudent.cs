﻿using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Servicio
{
    public interface IStudent
    {
        List<Students> ListOfStudent();

        void Insert(Students students);

        void Update(Students students);
    }
}
