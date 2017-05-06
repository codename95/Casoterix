using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carsoterix.Web.Models
{
    public class Membershiptype
    {
        public byte Id { get; set; }
        public string MembershipTypeName { get; set; }
        public short SignupFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte Discount { get; set; }
    }
}