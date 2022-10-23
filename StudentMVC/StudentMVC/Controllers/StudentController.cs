using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var student = new StudentMVC.Models.StudentBusinessLayer().GetById(142,"Jawad");
            ViewData["student"] = student;
            return View();
        }
    }
}