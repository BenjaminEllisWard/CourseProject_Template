using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoodItemTracker.Domain.Abstract;
using FoodItemTracker.Domain.Concrete;
using System.Collections.Generic;
using FoodItemTracker.Domain.Concrete.Repositories;
using FoodItemTracker.Domain.Concrete;
using System.Collections;
using System.Linq;

namespace FoodItemTracker.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Repository_Get_Table()
        {
            // Arrange
            EFItemRepository repo = new EFItemRepository();
            IEnumerable<FoodItem> inventory = repo.Inventory;
            FoodItem expected = new FoodItem()
            {
                ItemID = 1,
                Name = "Yum Crisps - test flavored",
                Quantity = 3,
                ExpDate = new DateTime(2012, 12, 22, 12, 00, 00),
                Location = "Refrigerator",
                Price = 3,
                Manufacturer = null,
                Batch = null
            };

            // Act
            FoodItem actual = repo.Inventory.First();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
