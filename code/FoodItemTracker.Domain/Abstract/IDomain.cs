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
        void AddToInventory(Item Id);
        bool CheckIfExists(Item Id);
        ItemType AddToTypes(Item type);
    }
}
