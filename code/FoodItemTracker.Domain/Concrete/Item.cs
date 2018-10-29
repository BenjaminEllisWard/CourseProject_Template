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
        public string Name { get; set;}
        public int Quantity { get; set; }
        public DateTime ExpDate { get; set; }
        public DateTime EntryDate { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Manufacturer { get; set; }
        public string Batch { get; set; }

        public Item(string id, string name, int quantity, DateTime expDate, DateTime entryDate,
                    string location, decimal price, string manufacturer, string batch)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.ExpDate = expDate;
            this.EntryDate = entryDate;
            this.Location = location;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Batch = batch;
        }
    }
}
