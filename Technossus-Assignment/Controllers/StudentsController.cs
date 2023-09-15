using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Technossus_Assignment.Models;
using Technossus_Assignment.Service;

namespace Technossus_Assignment.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentsService service;
        public StudentsController(IStudentsService service)
        {
            this.service = service;
        }

        // GET: StudentsController
        public ActionResult Index()
        {
            return View(service.GetAllStudents());
        }

        // GET: StudentsController/Details/5
        public ActionResult Detils(int id)
        {
            var st = service.GetStudentsById(id);
            return View(st);
        }

        // GET: StudentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Students st)
        {
            try
            {
                int result = service.AddStudents(st);
                if (result == 1)
                    return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: StudentsController/Edit/5
        public ActionResult Edit(int id)
        {
            var st = service.GetStudentsById(id);
            return View(st);
        }

        // POST: StudentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Students st)
        {
            try
            {
                int result = service.UpdateStudents(st);
                if (result == 1)
                    return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: StudentsController/Delete/5
        public ActionResult Delete(int id)
        {
            var st = service.GetStudentsById(id);
            return View(st);
        }

        // POST: StudentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                int result = service.DeleteStudents(id);
                if (result == 1)
                    return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            return View();
        }
    }
}
