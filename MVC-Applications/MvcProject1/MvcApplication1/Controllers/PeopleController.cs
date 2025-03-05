using Microsoft.AspNetCore.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { Id = 101, PName = "Kiran", Gender = "Male", Age = 30 });
            people.Add(new PersonModel { Id = 102, PName = "Rajesh", Gender = "Male", Age = 22 });
            people.Add(new PersonModel { Id = 103, PName = "Rajesh", Gender = "Male", Age = 22 });

            ViewBag.people = people;
            return View();
        }
    }
}
