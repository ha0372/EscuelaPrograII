using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Repositorio
{
    public class EnrollemntRepository : IRollements
    {
        private ApplicationDbContext bd;

        public EnrollemntRepository(ApplicationDbContext bd)
        {
            this.bd = bd;
        }

        public void Insert(Enrollment enrollment)
        {
            bd.Add(enrollment);
            bd.SaveChanges();
        }

        public List<Enrollment> ListOfEnrollment()
        {
            var union = bd.Enrollments.
                Include(e => e.Student).
                Include(c=>c.Course).
                Where(x => x.Student.stateStudent == true && x.Course.stateCourse == true).
                ToList();

            return union;
        }
    }
}
