﻿using Carsoterix.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Carsoterix.Web.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult CustomerInfo(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.CustomerId == id);
            if(customer==null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
    }
}