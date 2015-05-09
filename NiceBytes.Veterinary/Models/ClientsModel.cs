using System;
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

        [Column(TypeName = "INT")]
        public int ClientNumber { get; set; }

        [StringLength(50)]
        [Column(TypeName = "NVARCHAR")]
        public String FirstName { get; set; }

        [StringLength(50)]
        [Column(TypeName = "NVARCHAR")]
        public String LastName { get; set; }

        [StringLength(50)]
        [Column(TypeName = "NVARCHAR")]
        public String Email { get; set; }

        [Column(TypeName = "INT")]
        public int PhoneNumber { get; set; }

    }
}