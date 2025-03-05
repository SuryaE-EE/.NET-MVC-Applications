using DataApp.Models;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;

namespace DataApp.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeBO context = new EmployeeBO();
        public IActionResult Index()
        {
            ViewBag.employees = context.GetAllEmployees();
            return View();
        }

        public IActionResult Details(int id)
        {
            ViewBag.e = context.GetEmployeeById(id);
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(int id, string ename, string job, int salary)
        {
            EmployeeModel e = new EmployeeModel();
            e.Id = id;  e.EName = ename; e.Job = job; e.Salary = salary;
            context.AddEmployee(e);
            return View();
        }
    }
}
