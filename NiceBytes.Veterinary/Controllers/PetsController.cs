using NiceBytes.Veterinary.DAL;
using NiceBytes.Veterinary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NiceBytes.Veterinary.Controllers
{
    public class PetsController : Controller
    {
        private PetsDb petsDb = new PetsDb();
        // GET: Pets
        public ActionResult Index()
        {
            IEnumerable<PetsModel> pets = petsDb.Pets.ToList();
            return PartialView("_PetsPartial",pets);
        }

        // GET: Pets/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pets/Create
        public ActionResult Create()
        {
            return PartialView("_PetsPartial");
        }

        // POST: Pets/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pets/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pets/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pets/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pets/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
