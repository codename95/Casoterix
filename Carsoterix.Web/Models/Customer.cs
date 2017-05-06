using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carsoterix.Web.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CUstomerName { get; set; }

        public DateTime DateCreated { get; set; }
        public bool StatusId { get; set; }
        public bool IsSunscribedToNewsLetter { get; set; }
    }
}