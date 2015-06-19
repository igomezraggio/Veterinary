using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NiceBytes.Veterinary.Controllers
{
    public class RegistryController : Controller
    {
        // GET: Registry
        /*
        public ActionResult Index()
        {
            return View();
        }
         */
        public ActionResult Index(int idClient, int idPet)
        {
            return View();
        }

        
        // GET: Registry/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Registry/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registry/Create
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

        // GET: Registry/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Registry/Edit/5
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

        // GET: Registry/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Registry/Delete/5
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
