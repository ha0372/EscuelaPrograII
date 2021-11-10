using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class CourseController : Controller
    {
        private ApplicationDbContext connectDb;
        private ICourse icourse;

        public CourseController(ApplicationDbContext connectDb, ICourse icourse)
        {
            this.connectDb = connectDb;
            this.icourse = icourse;
        }
/******************************************************************************************************************************************************/
        public IActionResult Index()
        {
            var courseList = icourse.ListOfCourse();

            return View(courseList);
        }

/****************************************************************************************************************************************************/

        public IActionResult DataCourses(Course c)
        {
            ViewBag.id = c.CouserId;
            ViewBag.titulo = c.Title;
            ViewBag.credit = c.Credits;


            return View("DataCourses");
        }

        [HttpPost]
        public IActionResult Succes(Course co)
        {
            Course course = new Course();

            if (co.CouserId == 0)
            {
                course.Title = co.Title;
                course.Credits = co.Credits;
                course.stateCourse = true;

                icourse.Insert(course);
            }
            else
            {
                int codId = co.CouserId;
                Course update = connectDb.Courses.Where(i => i.CouserId == codId).FirstOrDefault();
                update.Title = co.Title;
                update.Credits = co.Credits;

                icourse.Update(update);

            }


            return Redirect("/Course/Index");
        }
    
/******************************************************************************************************************************************************/

        public IActionResult LogicalDelet(Course c)
        {
            int codId = c.CouserId;
            Course deleteC = connectDb.Courses.Where(x => x.CouserId == codId).FirstOrDefault();
            deleteC.stateCourse = false;

            icourse.Update(deleteC);

            return Redirect("/Course/Index");
        }
/******************************************************************************************************************************************************/

    }
}
