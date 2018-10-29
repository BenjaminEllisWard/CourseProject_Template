using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodItemTracker.Domain.Abstract;

namespace FoodItemTracker.Domain.Concrete
{
    struct ItemType : IType
    {
        public int TypeID { get; set; }
        public string Name { get; set; }
        public TimeSpan ShelfLife { get; set; }
        public string Manufacturer { get; set; }
    }
}
