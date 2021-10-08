﻿using Escuela.Dominio;
using Escuela.Models;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
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

        public HomeController(ILogger<HomeController> logger, ICourse icourse)
        {
            this.icourse = icourse;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Insert(string titulo, int creditos)
        {
            Course course = new Course();
            course.Title = titulo;
            course.Credits = creditos;

            icourse.Insertar(course);



            return View();
        }

        public IActionResult Index()
        {
            //Course course = new Course();
            //course.Title = "Poo";
            //course.Credits = 100;

            //icourse.Insertar(course);

            return View();
        }
        public IActionResult GetAll()
        {
            var FormatoJson = icourse.ListarCursos();

            return Json(new { data = FormatoJson });
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
