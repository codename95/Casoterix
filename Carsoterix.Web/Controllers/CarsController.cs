using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Carsoterix.Web.Models;
using System.Data.Entity;

namespace Carsoterix.Web.Controllers
{
    public class CarsController : Controller
    {
        private ApplicationDbContext _context;
        public CarsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Cars
        public ActionResult Index()
        {
            var cars = _context.Cars.Include(c => c.Color).Include(a => a.CarType).ToList();
            return View(cars);
        }
        public ActionResult CarInformation(int id)
        {
            var customer = _context.Cars.Include(a => a.CarType).Include(co => co.Color).SingleOrDefault(c => c.CarId == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
        public ActionResult JoinCarsoterix()
        {
            return View();
        }
    }
}