using System.Runtime.Intrinsics.X86;
using Microsoft.AspNetCore.Mvc;

namespace PostBackDemo.Controllers
{
    public class PostBackDemoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.msg = "Hello,Welcome";
            return View();
        }
        [HttpPost]  
        public IActionResult Index(string id)
        {
            ViewBag.msg = "Hi, Welcome Back";
            return View();
        }

        
    }
}
