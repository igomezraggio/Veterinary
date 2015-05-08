using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NiceBytes.Veterinary.Models
{
    public class ClientsModel
    {
        public int Id { get; set; }
        public String ClientNumber { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public int PhoneNumber { get; set; }
    }
}