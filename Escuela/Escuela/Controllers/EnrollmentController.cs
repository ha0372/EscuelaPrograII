using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class EnrollmentController : Controller
    {
        private ApplicationDbContext connectDb;
        private IRollements irollements;
        private IStudent istudent;
        private ICourse icourse;

        public EnrollmentController(ApplicationDbContext connectDb, IRollements irollements, IStudent istudent, ICourse icourse)
        {
            this.connectDb = connectDb;
            this.irollements = irollements;
            this.istudent = istudent;
            this.icourse = icourse;
        }
/************************************************************************************************************************************************/
        public IActionResult Index()
        {
            var enrollmentList = irollements.ListOfEnrollment();

            return View(enrollmentList);
        }

/************************************************************************************************************************************************/

        public IActionResult InfoEnrollmnt(Enrollment en)
        {
            return View("DataEnrollment");
        }

        public IActionResult DataEnrollment()
        {
            var cbxStudents = istudent.ListOfStudent();
            var cbxCourse = icourse.ListOfCourse();

            List<SelectListItem> listStudent = new List<SelectListItem>();
            List<SelectListItem> listCourse = new List<SelectListItem>();

            foreach (var item in cbxStudents)
            {
                listStudent.Add(
                    new SelectListItem
                    {
                        Text = item.LastName +" " + item.FirstMiName,
                        Value = Convert.ToString(item.StudentId)
                    });

                ViewBag.SList = listStudent;
            }
            foreach (var item in cbxCourse)
            {
                listCourse.Add(
                    new SelectListItem
                    {
                        Text = item.Title,
                        Value = Convert.ToString(item.CouserId)
                    });

                ViewBag.CList = listCourse;
            }

            return View();
        }

       [HttpPost]
        public IActionResult Succes(Enrollment enr)
        {
            Enrollment enrollment = new Enrollment();


            enrollment.CourseId = enr.CourseId;
            enrollment.StudentId = enr.StudentId;
            enrollment.grade = enr.grade;

            irollements.Insert(enrollment);


            return Redirect("/Enrollment/Index");
        }

        //public IActionResult Cbx()
        //{
        //    var cbxStudents = istudent.ListOfStudent();
        //    var cbxCourse = icourse.ListOfCourse();

        //    List<SelectListItem> listStudent = new List<SelectListItem>();
        //    List<SelectListItem> listCourse = new List<SelectListItem>();

        //    foreach (var item in cbxStudents)
        //    {
        //        listStudent.Add(
        //            new SelectListItem
        //            {
        //                Text = item.LastName + item.FirstMiName,
        //                Value = Convert.ToString(item.StudentId) 
        //            });

        //        ViewBag.SList = listStudent;
        //    }
        //    foreach (var item in cbxCourse)
        //    {
        //        listCourse.Add(
        //            new SelectListItem
        //            {
        //                Text = item.Title,
        //                Value = Convert.ToString(item.CouserId)
        //            });

        //        ViewBag.CList = listCourse;
        //    }

        //    return View();
        //}

/************************************************************************************************************************************************/
    }
}
