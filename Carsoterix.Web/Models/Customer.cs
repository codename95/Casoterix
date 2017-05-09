using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Carsoterix.Web.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Display(Name = "Credit Card No")]
        public string CreditCardInformation { get; set; }
        public Bank Bank { get; set; }
        [Display(Name = "Bank")]
        public byte BankId { get; set; }
        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }
        public DateTime DateCreated { get; set; }
        [Display(Name = "Newsletter Subscription")]
        public bool IsSubscribedToNewsLetter { get; set; }
        
        public Membershiptype MembershipType { get; set; }
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
    public class Bank
    {
        public byte BankId { get; set; }
        public string BankName { get; set; }
    }
}