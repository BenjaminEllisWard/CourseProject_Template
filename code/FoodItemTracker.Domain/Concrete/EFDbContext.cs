using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FoodItemTracker.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Item> Inventory { get; set; }
    }
}
