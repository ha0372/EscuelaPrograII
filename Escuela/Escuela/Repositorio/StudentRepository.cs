using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Repositorio
{
    public class StudentRepository : IStudent
    {
        private ApplicationDbContext bd;

        public StudentRepository(ApplicationDbContext bd)
        {
            this.bd = bd;
        }

        public void Insert(Students students)
        {
            bd.Add(students);
            bd.SaveChanges();
        }

        public List<Students> ListOfStudent()
        {
            var studentList = bd.Students.Where(x => x.stateStudent == true).ToList();/*Borrado Logico Filtro*/

            return /*bd.Students.ToList()*/studentList;
        }

        public void Update(Students students)
        {
            bd.Update(students);
            bd.SaveChanges();
        }
    }
}
