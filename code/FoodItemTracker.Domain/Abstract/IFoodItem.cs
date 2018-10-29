using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodItemTracker.Domain.Concrete;

namespace FoodItemTracker.Domain.Abstract
{
    public interface IFoodItem
    {
        int ItemID { get; set; }
        string Name { get; }
        int Quantity { get; }
        DateTime ExpDate { get; }
        DateTime EntryDate { get; }
        string Location { get; }
        decimal Price { get; }
        string Manufacturer { get; }
        string Batch { get; }
    }
}
