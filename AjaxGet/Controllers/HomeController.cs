using AjaxGet.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AjaxGet.Controllers
{
    public class HomeController : Controller
    {
        private readonly IList<Student> _students;

        public HomeController()
        {
            _students = new List<Student>()
            {
                new Student("Will", 3.3f),
                new Student("Liz", 3.5f),
                new Student("Jack", 4.0f)
            };
        }

        public ActionResult Index()
        {
            return View();
        }

        public string GetUserName(string firstname, string lastname)
        {
            return $"{firstname}&{lastname}";
            // "{firstname}&{lastname}" передается в качестве value на клиент
        }

        public double GenerateRandomNumber()
        {
            return new Random().NextDouble();
        }

        [HttpPost]
        public string AddStudent(Student student)
        {
            try
            {
                _students.Add(student);
                return "Successfully saved!";
            }
            catch (Exception)
            {
                return "Not saved!";
            }
        }

        public JsonResult GetStudents()
        {
            return Json(_students, JsonRequestBehavior.AllowGet);
        }

    }
}