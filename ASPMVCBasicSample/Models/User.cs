using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPMVCBasicSample.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GenderId { get; set; }
        public int AddressId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Favorite { get; set; }
        public string Question { get; set; }
    }

    public class Address
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}