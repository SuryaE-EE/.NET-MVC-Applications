using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentCrudApp1.Models;

namespace StudentCrudApp1.Controllers
{
    public class PeopleController : Controller
    {
        static PersonBO context = new PersonBO();
        // GET: PeopleController
        public ActionResult Index()
        {
            List<PersonModel> people = context.GetAll();
            return View(people); // model builing
        }

        // GET: PeopleController/Details/5
        public ActionResult Details(int id)
        {
            return View(context.GetById(id));
        }

        // GET: PeopleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PeopleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonModel p)
        {
            try
            {
                context.Create(p);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeopleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(context.GetById(id));
        }

        // POST: PeopleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PersonModel p)
        {
            try
            {
                context.Edit(p, id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeopleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.GetById(id));
        }

        // POST: PeopleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, PersonModel p)
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
