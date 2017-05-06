using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Carsoterix.Web.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        [Display(Name = "Nick Name/Pet Name")]
        public string CarName { get; set; }
        [Display(Name = "Renting Price")]
        public double RentingPrice { get; set; }
        
        public CarType CarType { get; set; }
        [Display(Name = "Brand")]
        public byte CarTypeId { get; set; }
        public string Year { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DateAdded { get; set; }
        [ScaffoldColumn(false)]
        public string ImagePath { get; set; }
        public CarOwner CarOwner { get; set; }
        public string Description { get; set; }
        [Display(Name = "Car Owned By")]
        public byte CarOwnerId { get; set; }
       // [ScaffoldColumn(false)]
        public bool IsAvailable { get; set; }
        public Color Color { get; set; }
        [Display(Name = "Color")]
        public byte ColorId { get; set; }
    }

    public class CarOwner
    {
        [Key]
        public byte CarOwnerId { get; set; }
        public string OwnerName { get; set; }
        public DateTime DateCreated { get; set; }
        public byte PercentageInterest { get; set; } //Interest Accruable to Owner for lease 
    }

    public class CarType
    {
        [Key]
        public byte CarTypeId { get; set; }
        public string CarTypeName { get; set; }
    }
    public class Color
    {
        [Key]
        public byte ColorId { get; set; }
        public string ColorName { get; set; }
    }
}