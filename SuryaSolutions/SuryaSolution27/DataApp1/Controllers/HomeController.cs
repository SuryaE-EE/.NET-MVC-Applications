using System.Data.SqlClient;
using System.Diagnostics;
using DataApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string cs = "server=DESKTOP-FHBRPJ7;integrated security=true;database=Surya";
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                ViewBag.color = "GREEN";
                ViewBag.msg = "Connection Established succcessfully...";
            }
            catch (SqlException ex)
            {
                ViewBag.color = "RED";
                ViewBag.msg = "DB Connection error " + ex.Message;
            }
            catch (Exception ex)
            {
                ViewBag.color = "RED";
                ViewBag.msg = "Error: " + ex.Message;
            }

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
