//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    using System.ComponentModel;
    
    public partial class ClientsModel
    {
        public ClientsModel()
        {
            this.PetsModels = new HashSet<PetsModel>();
        }
    
        public int Id { get; set; }

        [DisplayName("Nro. Socio")]
        public int ClientNumber { get; set; }

        [DisplayName("Nombre")]
        public string FirstName { get; set; }

        [DisplayName("Apellido")]
        public string LastName { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Tel�fono")]
        public int PhoneNumber { get; set; }

        [DisplayName("F. de Ingreso")]
        public System.DateTime DateEntry { get; set; }
    
        public virtual ICollection<PetsModel> PetsModels { get; set; }
    }
}
