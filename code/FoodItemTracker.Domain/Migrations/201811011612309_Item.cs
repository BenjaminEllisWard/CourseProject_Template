namespace FoodItemTracker.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Item : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Items", newName: "Inventory");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Inventory", newName: "Items");
        }
    }
}
