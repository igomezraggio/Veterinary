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
        private ClientsDb clientsDb = new ClientsDb();
        private int currentClientId = -1;
        // GET: Pets
        public ActionResult Index(int id)
        {
            IEnumerable<PetsModel> pets = clientsDb.GetClientPets(id);
            currentClientId = id;
            ViewBag.ClientId = id;
            return PartialView("_PetsPartial",pets);
        }

        // GET: Pets/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pets/Create
        public ActionResult Create(int id)
        {
            PetsModel newPet = new PetsModel();
            newPet.ClientsModelId = id;
            newPet.DateEntry = DateTime.Now;
            return PartialView("_CreatePet", newPet);
        }

        // POST: Pets/Create
        [HttpPost]
        public ActionResult Create(PetsModel newPet)
        {
            newPet.DateEntry = DateTime.Now;
            ClientsController clientController = new ClientsController();
            ClientsModel client = clientController.GetClient(newPet.ClientsModelId);
            if (!ModelState.IsValid)
            {
                return PartialView("_CreatePet", newPet);
            }
            else
            {
                bool IsSuccess = clientsDb.AddPet(client,newPet);
                if (IsSuccess)
                {
                    ModelState.Clear();
                    return Json(new { success = true, responseText = "Your message successfuly sent!" }, JsonRequestBehavior.AllowGet);
                }
            }
            return PartialView("_CreatePet", newPet);
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

        [HttpPost]
        public void Delete(int idClient, PetsModel pet)
        {
            // TODO: Add delete logic here
            clientsDb.DeletePet(idClient,pet);

        }
    }
}
