using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodItemTracker.Domain.Abstract
{
    interface IType
    {
        int TypeID { get; set; }
        string Name { get; set; }
        TimeSpan ShelfLife { get; set; }
        string Manufacturer { get; set; }
    }
}
