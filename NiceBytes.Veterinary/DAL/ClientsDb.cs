using NiceBytes.Veterinary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NiceBytes.Veterinary.DAL
{
    public class ClientsDb :DbContext
    {
        private bool clientDbChanged;

        public ClientsDb()
            : base("DefaultConnection")
        {
        }

        public static ClientsDb Create()
        {
            return new ClientsDb();
        }

        public DbSet<ClientsModel> Clients { get; set; }
        
        public DbSet<PetsModel> PetsModels { get; set; }

        public DbSet<Registry> Registries { get; set; }

        public bool AddClient(ClientsModel client)
        {
            try
            {
                Clients.Add(client);
                this.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ClientsModel GetClient(int clientNumber)
        {
            try
            {
                return Clients.Where(m => m.ClientNumber == clientNumber).FirstOrDefault();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public ClientsModel GetClientById(int id)
        {
            try
            {
                return Clients.Where(m => m.Id == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public IEnumerable<ClientsModel> GetAllClients()
        {
            return Clients.ToList();
        }

        public bool UpdateClient(ClientsModel client)
        {
            var clientFound = Clients.Where(p => p.ClientNumber == client.ClientNumber);
            if (!clientFound.Any())
                return false;

            var cl = clientFound.FirstOrDefault();
            Clients.Remove(cl);
            Clients.Add(client);
            this.SaveChanges();
            return true;
        }

        public bool DeleteClient(int clientNumber)
        {
            ClientsModel client = GetClient(clientNumber);
            try
            {
                Clients.Remove(client);
                this.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public IEnumerable<PetsModel> GetClientPets(int clientId)
        {
            ClientsModel client = Clients.Where(x => x.Id == clientId).FirstOrDefault();
            return client.PetsModels.ToList();
        }

        public bool AddPet(ClientsModel client, PetsModel pet)
        {
            try
            {
                var clientDb = Clients.Find(client.Id);
                clientDb.PetsModels.Add(pet);
                this.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeletePet(int clientId, PetsModel pet)
        {
            try
            {
                var clientDb = Clients.Find(clientId);
                var petToDelete = clientDb.PetsModels.Where(x => x.Id == pet.Id).FirstOrDefault();
                var petToDelete2 = PetsModels.Where(x => x.Id == pet.Id).FirstOrDefault();
                PetsModels.Remove(petToDelete2);
                this.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        
    }
}