using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Carsoterix.Web.Models;

namespace Carsoterix.Web.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            var car = new Car() {CarName = "Toyota Corolla"};
            return View(car);
        }
    }
}