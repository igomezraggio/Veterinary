using NiceBytes.Veterinary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NiceBytes.Veterinary.DAL
{
    public class PetsDb :DbContext
    {
        public PetsDb()
            : base("DefaultConnection")
        {
        }

        public static PetsDb Create()
        {
            return new PetsDb();
        }

        public DbSet<PetsModel> Pets { get; set; }
        /*
        public IEnumerable<PetsModel> GetPetsOfClient(int clientId) 
        {
            var pets = Pets.Where(x => x.ClientsModelId == clientId);
            if(pets.Any())
            {
                return pets.ToList();
            }
            return null;
        }
        
        public bool AddPet(PetsModel pet)
        {
            try
            {
                
                pet.Client.PetsModels.Add(pet);
                this.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        */
        public System.Data.Entity.DbSet<NiceBytes.Veterinary.Models.ClientsModel> ClientsModels { get; set; }
    }
}