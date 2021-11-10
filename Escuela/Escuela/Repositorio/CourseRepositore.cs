using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Repositorio
{
    public class CourseRepositore : ICourse
    {
        private ApplicationDbContext bd;

        public CourseRepositore(ApplicationDbContext bd)
        {
            this.bd = bd;
        }
        //public void Buscar(Course c)
        //{
        //    app.Courses.Find(c);
        //}

        //public void Delete(Course c)
        //{
        //    app.Courses.Remove(c);
        //}

        public void Insert(Course course)
        {
            bd.Add(course);
            bd.SaveChanges();
        }


        public void Update(Course course)
        {
            bd.Update(course);
            bd.SaveChanges();
        }

        public List<Course> ListOfCourse()
        {
            var courseList = bd.Courses.Where(x => x.stateCourse == true).ToList();/*filtro borrado logico*/

            return /*bd.Courses.ToList()*/courseList;
        }


    }
}
