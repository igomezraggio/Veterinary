﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NiceBytes.Veterinary.Models
{
    public class ClientsModel
    {
        [Column(TypeName="INT")]
        public int Id { get; set; }

        [Required]
        [Display(Name="Socio")]
        [Column(TypeName = "INT")]
        public int ClientNumber { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(50)]
        [Column(TypeName = "NVARCHAR")]
        public String FirstName { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        [StringLength(50)]
        [Column(TypeName = "NVARCHAR")]
        public String LastName { get; set; }

        [Display(Name = "Email")]
        [StringLength(50)]
        [Column(TypeName = "NVARCHAR")]
        public String Email { get; set; }

        [Display(Name = "Teléfono")]
        [Column(TypeName = "INT")]
        public int PhoneNumber { get; set; }

        [Display(Name = "Ingreso")]
        [Column(TypeName = "DATE")]
        public DateTime DateEntry { get; set; }

        public DbSet<PetsModel> PetsModels { get; set; }
    }
}