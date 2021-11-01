﻿using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Servicio
{
    public interface ICourse
    {

        void Insertar(Course c);

        void Delete(Course c);

        void Update(Course c);
        //List<Course> ListarCursos();

        ICollection<Course> ListarCursos();

    }
}
