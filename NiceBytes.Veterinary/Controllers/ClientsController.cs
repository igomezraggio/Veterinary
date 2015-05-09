using NiceBytes.Veterinary.DAL;
using NiceBytes.Veterinary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NiceBytes.Veterinary.Controllers
{
    public class ClientsController : Controller
    {
        private ClientsDb clientsDb = new ClientsDb();
        // GET: Client
        public ActionResult Index()
        {
            var clients = clientsDb.Clients;
            return View(clients.ToList());
        }

        // GET: Client/Details
        public ActionResult Details()
        {
            var client = new ClientsModel { Id = 1, ClientNumber = 1111, FirstName = "Sabrina", LastName = "Estala", 
                                            Email = "sabrina.estala@gmail.com", PhoneNumber = 99665684};
            return View(client);
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
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

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Client/Edit/5
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

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client/Delete/5
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
