using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NiceBytes.Veterinary.Models
{
    public class PetsModel
    {
        [Column(TypeName="INT")]
        public int Id { get; set; }

        [Required]
        [Display(Name="Mascota")]
        [Column(TypeName = "INT")]
        public int PetNumber { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(50)]
        [Column(TypeName = "NVARCHAR")]
        public String FirstName { get; set; }

        [Required]
        [Display(Name = "Sexo")]
        [StringLength(1)]
        [Column(TypeName = "NVARCHAR")]
        public String Gender { get; set; }

        [Display(Name = "Nacimiento")]
        [Column(TypeName = "DATE")]
        public DateTime DateBirth { get; set; }

        [Display(Name = "Raza")]
        [StringLength(40)]
        [Column(TypeName = "NVARCHAR")]
        public String Breed { get; set; }

        [Display(Name = "Color")]
        [StringLength(30)]
        [Column(TypeName = "NVARCHAR")]
        public String Colour { get; set; }

        [Display(Name = "Ingreso")]
        [Column(TypeName = "DATE")]
        public DateTime DateEntry { get; set; }

        public virtual ClientsModel Client {get; set;}
        public int ClientsModelId { get; set; }
    }

}