using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace BankAccount.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string name, string pwd)
        {
            if (name == "surya" && pwd == "surya")
            {
                HttpContext.Session.SetString("name", name);
                return RedirectToAction("Dashboard");
            }
            ViewBag.msg = "Invalid Input Credentials!!!";
            ViewBag.color = "RED";
                return View();
        }

        public IActionResult Dashboard()

        {
            if(HttpContext.Session.GetString("name")!=null)
            {
                var name = HttpContext.Session.GetString("name");
                ViewBag.user = name;
            }

            return View();
        }

        public IActionResult Confidential()
        {
            if (HttpContext.Session.GetString("name") != null)
            {
                var name = HttpContext.Session.GetString("name");
                ViewBag.user = name;
            }
            return View();
        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("name") != null)
            {
                var name = HttpContext.Session.GetString("name");
                ViewBag.user = name;
                HttpContext.Session.Clear();
            }
            return View();
        }
    }
}
