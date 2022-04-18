namespace ResturantApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Unknown2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CashierId", c => c.Byte(nullable: false));
            AddColumn("dbo.Products", "Cashier_Id", c => c.Int());
            CreateIndex("dbo.Products", "Cashier_Id");
            AddForeignKey("dbo.Products", "Cashier_Id", "dbo.Cashiers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Cashier_Id", "dbo.Cashiers");
            DropIndex("dbo.Products", new[] { "Cashier_Id" });
            DropColumn("dbo.Products", "Cashier_Id");
            DropColumn("dbo.Products", "CashierId");
        }
    }
}
