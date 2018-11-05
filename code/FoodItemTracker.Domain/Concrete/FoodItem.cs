using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodItemTracker.Domain.Abstract;

namespace FoodItemTracker.Domain.Concrete
{
    [Table("Inventory")]
    public class FoodItem : IFoodItem
    {
        [Key]
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
