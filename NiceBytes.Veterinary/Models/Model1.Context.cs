﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NiceBytes.Veterinary.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db1d7665e0137842feb3c1a492001e177dEntities : DbContext
    {
        public db1d7665e0137842feb3c1a492001e177dEntities()
            : base("name=db1d7665e0137842feb3c1a492001e177dEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClientsModel> ClientsModels { get; set; }
        public virtual DbSet<PetsModel> PetsModels { get; set; }
        public virtual DbSet<Registry> Registries { get; set; }
    }
}
