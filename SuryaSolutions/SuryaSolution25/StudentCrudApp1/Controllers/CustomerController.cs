using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentCrudApp1.Models;

namespace StudentCrudApp1.Controllers
{
    public class CustomerController : Controller
    {
        static CustomerBO context = new CustomerBO();
        
        // GET: CustomerController
        public ActionResult Index()
        {
            return View(context.GetAll());
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View(context.GetByid(id));
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerModel c)
        {
            try
            {
                context.AddCustomer(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(context.GetByid(id));
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerModel c)
        {
            try
            {
                context.Edit(c, id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.GetByid(id));
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CustomerModel c)
        {
            try
            {   
                context.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
