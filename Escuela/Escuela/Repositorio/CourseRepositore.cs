﻿using Escuela.Data;
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
        private ApplicationDbContext app;

        public CourseRepositore(ApplicationDbContext app)
        {
            this.app = app;
        }
        public void Buscar(Course c)
        {
            app.Courses.Find(c);
        }

        public void Delete(Course c)
        {
            app.Courses.Remove(c);
        }

        public void Insertar(Course c)
        {
            app.Add(c);
            app.SaveChanges();
        }


        public void Update(Course c)
        {
            app.Update(c);
            app.SaveChanges();
        }

        public ICollection<Course> ListarCursos()
        {
            return app.Courses.ToList();
        }


    }
}
