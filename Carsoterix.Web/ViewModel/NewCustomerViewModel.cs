using Carsoterix.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carsoterix.Web.ViewModel
{
    public class NewCustomerViewModel
    {
        public IEnumerable<Membershiptype> MembershipTypes { get; set; }
        public IEnumerable<Bank> Banks { get; set; }
        public Customer Customer { get; set; }
    }
}