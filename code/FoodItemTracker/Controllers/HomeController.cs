using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FoodItemTracker.Domain.Concrete.Repositories;
using FoodItemTracker.Domain.Concrete;

namespace FoodItemTracker.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            EFItemRepository repo = new EFItemRepository();
            IEnumerable<FoodItem> inventory = repo.Inventory;
            return inventory.First().Location;
        }
    }
}