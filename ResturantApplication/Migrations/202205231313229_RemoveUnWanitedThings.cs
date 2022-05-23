namespace ResturantApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUnWanitedThings : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Cashier_Id", "dbo.Cashiers");
            DropForeignKey("dbo.Products", "Items_Id", "dbo.Items");
            DropForeignKey("dbo.Products", "PaymentType_Id", "dbo.PaymentTypes");
            DropIndex("dbo.Products", new[] { "Cashier_Id" });
            DropIndex("dbo.Products", new[] { "Items_Id" });
            DropIndex("dbo.Products", new[] { "PaymentType_Id" });
            DropColumn("dbo.Products", "CashierId");
            DropColumn("dbo.Products", "ItemsId");
            DropColumn("dbo.Products", "PaymentTypeId");
            RenameColumn(table: "dbo.Products", name: "Cashier_Id", newName: "CashierId");
            RenameColumn(table: "dbo.Products", name: "Items_Id", newName: "ItemsId");
            RenameColumn(table: "dbo.Products", name: "PaymentType_Id", newName: "PaymentTypeId");
            AlterColumn("dbo.Products", "ItemsId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "PaymentTypeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "CashierId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "CashierId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "ItemsId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "PaymentTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "ItemsId");
            CreateIndex("dbo.Products", "PaymentTypeId");
            CreateIndex("dbo.Products", "CashierId");
            AddForeignKey("dbo.Products", "CashierId", "dbo.Cashiers", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Products", "ItemsId", "dbo.Items", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Products", "PaymentTypeId", "dbo.PaymentTypes", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "PaymentTypeId", "dbo.PaymentTypes");
            DropForeignKey("dbo.Products", "ItemsId", "dbo.Items");
            DropForeignKey("dbo.Products", "CashierId", "dbo.Cashiers");
            DropIndex("dbo.Products", new[] { "CashierId" });
            DropIndex("dbo.Products", new[] { "PaymentTypeId" });
            DropIndex("dbo.Products", new[] { "ItemsId" });
            AlterColumn("dbo.Products", "PaymentTypeId", c => c.Int());
            AlterColumn("dbo.Products", "ItemsId", c => c.Int());
            AlterColumn("dbo.Products", "CashierId", c => c.Int());
            AlterColumn("dbo.Products", "CashierId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Products", "PaymentTypeId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Products", "ItemsId", c => c.Byte(nullable: false));
            RenameColumn(table: "dbo.Products", name: "PaymentTypeId", newName: "PaymentType_Id");
            RenameColumn(table: "dbo.Products", name: "ItemsId", newName: "Items_Id");
            RenameColumn(table: "dbo.Products", name: "CashierId", newName: "Cashier_Id");
            AddColumn("dbo.Products", "PaymentTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Products", "ItemsId", c => c.Byte(nullable: false));
            AddColumn("dbo.Products", "CashierId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Products", "PaymentType_Id");
            CreateIndex("dbo.Products", "Items_Id");
            CreateIndex("dbo.Products", "Cashier_Id");
            AddForeignKey("dbo.Products", "PaymentType_Id", "dbo.PaymentTypes", "Id");
            AddForeignKey("dbo.Products", "Items_Id", "dbo.Items", "Id");
            AddForeignKey("dbo.Products", "Cashier_Id", "dbo.Cashiers", "Id");
        }
    }
}
