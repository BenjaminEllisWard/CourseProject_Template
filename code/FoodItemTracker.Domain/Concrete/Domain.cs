using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodItemTracker.Domain.Abstract;

namespace FoodItemTracker.Domain.Concrete
{
    class Domain : IDomain
    {

        public void AddToInventory(Item item)
        {
            // EF required here
            throw new NotImplementedException();
        }

        public ItemType AddToTypes(Item item)
        {
            ItemType type = new ItemType
            {
                Name = item.Name,
                ShelfLife = item.ExpDate - DateTime.Now,
                Manufacturer = item.Manufacturer
            };

            // Ef required here
            throw new NotImplementedException();
        }

        public bool CheckIfExists(Item item)
        {
            // check item types table
            // return as appropriate
            throw new NotImplementedException("CheckIfExists not implemented");
        }
    }
}
