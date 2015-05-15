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
    }
}