using Carsoterix.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Carsoterix.Web.ViewModel;

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
            var customers = _context.Customers.Include(c => c.MembershipType).Include(y => y.Bank).ToList();
            return View(customers);
        }

        public ActionResult CustomerInfo(int id)
        {
            var customer = _context.Customers.Include(b => b.Bank).SingleOrDefault(c => c.CustomerId == id);
            if(customer==null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
        public ActionResult New()
        {
            var membershipType = _context.Membershiptype.ToList();
            var banks = _context.Bank.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipType,
                Banks = banks
            };
            return View("CustomerForm", viewModel);
        }
        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if(customer.CustomerId ==0)
            {
                customer.DateCreated = DateTime.Now;
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInModel = _context.Customers.Single(d => d.CustomerId == customer.CustomerId);
                //TryUpdateModel(customerInModel); -- This opens security loophole
                //TryUpdateModel(customerInModel, "", new string[] {"Name", "Email"}); -- Flawed, If we change model we need to change this
                customerInModel.CustomerName = customer.CustomerName;
                customerInModel.BirthDate = customer.BirthDate;
                customerInModel.MembershipTypeId = customer.MembershipTypeId;
                customerInModel.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
                customerInModel.BankId = customer.BankId;

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.CustomerId == id);
            if(customer == null)
            {
                return HttpNotFound();

            }
            var viewModel = new NewCustomerViewModel
            {
                Customer = customer,
                MembershipTypes = _context.Membershiptype.ToList(),
                Banks = _context.Bank.ToList()
            };
            return View("CustomerForm", viewModel);
        }
    }
}