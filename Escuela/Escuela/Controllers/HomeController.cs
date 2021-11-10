using Escuela.Dominio;
using Escuela.Models;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICourse icourse;
        private IRollements irollements;
        private IStudent istudent;

        public HomeController(ILogger<HomeController> logger, ICourse icourse, IRollements irollements, IStudent istudent)
        {
            this.icourse = icourse;
            this.irollements = irollements;
            this.istudent = istudent;
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            //_ = listado;

            //Course course = new Course();
            //course.Title = "Poo";
            //course.Credits = 100;

            //icourse.Insertar(course);

            return View();
        }
/****************************************************************************************************************************************************/
        public IActionResult GetAllForJoinJsonLinq()
        {

            var listado = irollements.ListOfEnrollment();

            var combinacionArreglos = (from union in listado
                                       select new
                                       {
                                           union.Course.Title,
                                           union.Student.LastName,
                                           union.Student.FirstMiName,
                                           union.grade
                                       }).ToList();

            return Json(new {combinacionArreglos});
        }


/***************************************************************************************************************************************************/
        public IActionResult InnerJ()
        {
            var listado = irollements.ListOfEnrollment();

            return View(listado);
        }

/***************************************************************************************************************************************************/

        public IActionResult getinformationcbb( Enrollment e)
        {
            return View("ComboBox");
        }


        public IActionResult ComboBox()
        {

            var informationOftheCombo = icourse.ListOfCourse();
            var informationOftheComboforStudent = istudent.ListOfStudent();

            List<SelectListItem> list = new List<SelectListItem>();
            List<SelectListItem> listStudent = new List<SelectListItem>();

            foreach (var  iterarInfo in informationOftheCombo)
            {
                list.Add(
                    new SelectListItem
                    {
                        Text = iterarInfo.Title,
                        Value = Convert.ToString(iterarInfo.CouserId)
                    });

                ViewBag.estadolistcourse = list;
            }

            foreach (var iterarInfo in informationOftheComboforStudent)
            {
                listStudent.Add(
                    new SelectListItem
                    {
                        Text = iterarInfo.FirstMiName,
                        Value = Convert.ToString(iterarInfo.StudentId)
                    });

                ViewBag.estadoliststudent = listStudent;
            }

            return View();
        }

/**************************************************************************************************************************************************/
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(string titulo, int creditos)
        {
            Course course = new Course();
            course.Title = titulo;
            course.Credits = creditos;

            icourse.Insert(course);



            return View();
        }
/*****************************************************************************************************************************************************/
        public IActionResult GetAll()
        {
            var FormatoJson = icourse.ListOfCourse();

            return Json(new { data = FormatoJson });
        }
/***************************************************************************************************************************************************/
        
        public IActionResult Parcial()
        {
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
