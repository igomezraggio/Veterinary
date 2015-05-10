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
        public ClientsDb()
            : base("DefaultConnection")
        {
        }

        public static ClientsDb Create()
        {
            return new ClientsDb();
        }

        public DbSet<ClientsModel> Clients { get; set; }

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

        public ClientsModel GetClient(int id)
        {
            try
            {
                return Clients.Where(m => m.ClientNumber == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                return null;
            }
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
    }
}