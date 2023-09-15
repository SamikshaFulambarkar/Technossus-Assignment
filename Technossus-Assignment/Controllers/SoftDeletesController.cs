using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Technossus_Assignment.Models;
using Technossus_Assignment.Service;

namespace Technossus_Assignment.Controllers
{
    public class SoftDeletesController : Controller
    {
        private readonly ISoftDeletesService service;
        public SoftDeletesController(ISoftDeletesService service)
        {
            this.service = service;
        }

        // GET: SoftDeletesController
        public ActionResult Index()
        {
            return View(service.GetAllSoftDeletes());
        }

        // GET: SoftDeletesController/Details/5
        public ActionResult Details(int id)
        {
            var sd = service.GetSoftDeletesById(id);
            return View(sd);
        }

        // GET: SoftDeletesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SoftDeletesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SoftDeletes sd)
        {
            try
            {
                int result = service.AddSoftDeletes(sd);
                if (result == 1)
                    return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: SoftDeletesController/Edit/5
        public ActionResult Edit(int id)
        {
            var sd = service.GetSoftDeletesById(id);
            return View(sd);
        }

        // POST: SoftDeletesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SoftDeletes sd)
        {
            try
            {
                int result = service.UpdateSoftDeletes(sd);
                if (result == 1)
                    return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: SoftDeletesController/Delete/5
        public ActionResult Delete(int id)
        {
            var sd = service.GetSoftDeletesById(id);
            return View(sd);
        }

        // POST: SoftDeletesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                int result = service.DeleteSoftDeletes(id);
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
