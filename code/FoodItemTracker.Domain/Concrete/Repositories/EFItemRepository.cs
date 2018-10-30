using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodItemTracker.Domain.Concrete;
using FoodItemTracker.Domain.Abstract;

namespace FoodItemTracker.Domain.Concrete.Repositories
{
    public class EFItemRepository : IItemRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Item> Inventory
        {
            get { return context.Inventory; }
        }
    }
}
