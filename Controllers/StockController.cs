using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myChoice.Models;

namespace myChoice.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult searchForInstock(string nameOfItem, string department, int numberInStock)
        {
            inventory i = new inventory()
            {
                nameOfItem = nameOfItem,
                department = department,
                numberInStock = numberInStock

            };
            return View("confirmAmountOfStock", i);
        }
        public ActionResult searchForInstock()
        {
            return View("newSearchForm");
        }
    }
}