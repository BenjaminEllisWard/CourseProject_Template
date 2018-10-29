using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodItemTracker.Domain.Concrete
{
    struct ItemType
    {
        public string Name { get; set; }
        public TimeSpan ShelfLife { get; set; }
        public string Manufacturer { get; set; }
    }
}
