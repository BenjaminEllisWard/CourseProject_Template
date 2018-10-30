using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodItemTracker.Domain.Concrete;

namespace FoodItemTracker.Domain.Abstract
{
    public interface IItemRepository
    {
        IEnumerable<Item> Inventory { get; }
    }
}
