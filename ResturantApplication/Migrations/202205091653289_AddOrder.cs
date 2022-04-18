namespace ResturantApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        PaymentTypeId = c.Byte(nullable: false),
                        CashierId = c.Byte(nullable: false),
                        OrderNumber = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        FinalTotal = c.Int(nullable: false),
                        Cashier_Id = c.Int(),
                        PaymentType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Cashiers", t => t.Cashier_Id)
                .ForeignKey("dbo.PaymentTypes", t => t.PaymentType_Id)
                .Index(t => t.Cashier_Id)
                .Index(t => t.PaymentType_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "PaymentType_Id", "dbo.PaymentTypes");
            DropForeignKey("dbo.Orders", "Cashier_Id", "dbo.Cashiers");
            DropIndex("dbo.Orders", new[] { "PaymentType_Id" });
            DropIndex("dbo.Orders", new[] { "Cashier_Id" });
            DropTable("dbo.Orders");
        }
    }
}
