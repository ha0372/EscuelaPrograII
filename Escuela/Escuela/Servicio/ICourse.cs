using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Servicio
{
    public interface ICourse
    {

        void Insert(Course c);

        void Update(Course c);

        List<Course> ListOfCourse();

    }
}

//List<Course> ListarCursos();
//void Delete(Course c);