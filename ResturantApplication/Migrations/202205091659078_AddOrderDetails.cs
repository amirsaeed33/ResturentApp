namespace ResturantApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailsId = c.Int(nullable: false, identity: true),
                        OrderId = c.Byte(nullable: false),
                        ItemsId = c.Byte(nullable: false),
                        UnitPrice = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                        Items_Id = c.Int(),
                        Order_OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderDetailsId)
                .ForeignKey("dbo.Items", t => t.Items_Id)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .Index(t => t.Items_Id)
                .Index(t => t.Order_OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "Items_Id", "dbo.Items");
            DropIndex("dbo.OrderDetails", new[] { "Order_OrderId" });
            DropIndex("dbo.OrderDetails", new[] { "Items_Id" });
            DropTable("dbo.OrderDetails");
        }
    }
}
