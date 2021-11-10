using Escuela.Dominio;
using Escuela.Data;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class StudentsController : Controller
    {
        private IStudent istudent;
        private ApplicationDbContext connectDb;

        public StudentsController(ApplicationDbContext bd, IStudent istudent)
        {
            this.connectDb = bd;
            this.istudent = istudent;
        }
/******************************************************************************************************************************************************/
        public IActionResult Index()
        {
            var studentList = istudent.ListOfStudent();

            return View(studentList);
        }


/******************************************************************************************************************************************************/
        //[HttpPost]
        public IActionResult DataEstudents(Students e)
        {
            ViewBag.id = e.StudentId;
            ViewBag.lastName = e.LastName;
            ViewBag.name = e.FirstMiName;
            ViewBag.date = e.EnrollmentsDate;


            return View("DataEstudents");
        }

        [HttpPost]
        public IActionResult Succes(Students es)
        {
            Students students = new Students();

            if (es.StudentId == 0)
            {
                students.LastName = es.LastName;
                students.FirstMiName = es.FirstMiName;
                students.EnrollmentsDate = es.EnrollmentsDate /*DateTime.Now*/;
                students.stateStudent = true;

                istudent.Insert(students);
            }
            else
            {
                int codId = es.StudentId;
                Students update = connectDb.Students.Where(i => i.StudentId == codId).FirstOrDefault();
                update.LastName = es.LastName;
                update.FirstMiName = es.FirstMiName;
                //update.EnrollmentsDate = es.EnrollmentsDate;

                istudent.Update(update);

            }
            
            
            return Redirect("/Students/Index");
        }
/***************************************************************************************************************************************************/

        public IActionResult LogicalDelet(Students e)
        {
            int codId = e.StudentId;
            Students deleteL = connectDb.Students.Where(x => x.StudentId == codId).FirstOrDefault();
            deleteL.stateStudent = false;

            istudent.Update(deleteL);

            return Redirect("/Students/Index");
        }
/******************************************************************************************************************************************************/

    }
}
