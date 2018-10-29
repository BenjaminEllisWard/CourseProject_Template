using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodItemTracker.Domain.Abstract;

namespace FoodItemTracker.Domain.Concrete
{
    public class Item : IFoodItem
    {
        public int ItemID { get; set; }
        public string Name { get; set;}
        public int Quantity { get; set; }
        public DateTime ExpDate { get; set; }
        public DateTime EntryDate { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Manufacturer { get; set; }
        public string Batch { get; set; }
    }
}
