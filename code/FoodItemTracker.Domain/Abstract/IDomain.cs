using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodItemTracker.Domain.Concrete;

namespace FoodItemTracker.Domain.Abstract
{
    interface IDomain
    {
        void AddToInventory(FoodItem item);
        bool CheckIfExists(FoodItem item);
        ItemType AddToTypes(FoodItem item);
    }
}
