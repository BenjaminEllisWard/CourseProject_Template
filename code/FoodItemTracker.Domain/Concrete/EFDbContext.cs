using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodItemTracker.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        
        public DbSet<FoodItem> Inventory { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // base.OnModelCreating(modelBuilder);
        //    modelBuilder.Conventions.Remove<PluralizingNameConvention>();

        //}
    }
}
