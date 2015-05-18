using NiceBytes.Veterinary.DAL;
using NiceBytes.Veterinary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace NiceBytes.Veterinary.Controllers
{
    public class ClientsController : Controller
    {
        private ClientsDb clientsDb = new ClientsDb();
        private bool clientDbChanged;
        // GET: Client
        public ActionResult Index()
        {
            IEnumerable<ClientsModel> clients = clientsDb.GetAllClients();
            return View(clients);
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
            return PartialView("_CreateClient");
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(ClientsModel newClient)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("_CreateClient", newClient);
            }
            else
            {
                bool IsSuccess = clientsDb.AddClient(newClient);
                if (IsSuccess)
                {
                    TempData["OperStatus"] = "Employee added succeessfully";
                    ModelState.Clear();
                    return RedirectToAction("Index");
                }
            }
            return PartialView("_CreateClient");
        }

        // GET: Client/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ClientsModel client = clientsDb.GetClient(id);

            //ViewBag.IsUpdate = true;
            return PartialView("_EditClient", client);
        }

        public ClientsModel GetClient(int id){
            return clientsDb.GetClientById(id);
        }
        // POST: Client/Edit/5
        /*
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
        */

        [HttpPost]
        public ActionResult Edits(ClientsModel client)
        {
            
            clientsDb.UpdateClient(client);
            clientDbChanged = true;
            
            return Json(new { success = true, responseText = "Your message successfuly sent!" }, JsonRequestBehavior.AllowGet);
            //return RedirectToAction("Index");
            /*{
                return RedirectToAction("Index");
            }*/
            //return PartialView("_EditClient", client);
        }
        
        // GET: Client/Delete/5
        /*
        public ActionResult Delete(int id)
        {
            return View();
        }
        */
        // POST: Client/Delete/5
        [HttpPost]
        public void Delete(int id)
        {
            // TODO: Add delete logic here
            clientsDb.DeleteClient(id);

        }
    }
}
