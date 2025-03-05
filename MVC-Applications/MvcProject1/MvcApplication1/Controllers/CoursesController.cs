using Microsoft.AspNetCore.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class CoursesController : Controller

    {
        public IActionResult Index()

        {

            List<CourseModel> courses = new List<CourseModel>();
            courses.Add(new CourseModel { Id = 101, Course = ".Net", Faculty = "Kiran", DurationInDays = 30, Fees = 500 });
            courses.Add(new CourseModel { Id = 102, Course = "Python", Faculty = "Kiran", DurationInDays = 30, Fees = 600 });
            courses.Add(new CourseModel { Id = 103, Course = "Anaconda", Faculty = "Kiran", DurationInDays = 30, Fees = 700 });
            ViewBag.courses = courses;
            return View();

        }
    }
}

