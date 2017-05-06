using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carsoterix.Web.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public DateTime DateCreated { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public Membershiptype MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}