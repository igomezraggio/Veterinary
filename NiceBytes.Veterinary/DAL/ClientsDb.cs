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
    }
}