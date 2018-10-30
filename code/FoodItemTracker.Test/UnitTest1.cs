using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoodItemTracker.Domain.Abstract;
using FoodItemTracker.Domain.Concrete;
using System.Collections.Generic;


namespace FoodItemTracker.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Repository_Get_Table()
        {
            EFDbContext repo = new EFDbContext();
            IEnumerable<Item> inventory = repo.Inventory;

            Console.WriteLine(inventory);
        }
    }
}
