namespace ResturantApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTransaction : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        ItemsId = c.Byte(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TransactionDate = c.DateTime(nullable: false),
                        Items_Id = c.Int(),
                    })
                .PrimaryKey(t => t.TransactionId)
                .ForeignKey("dbo.Items", t => t.Items_Id)
                .Index(t => t.Items_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "Items_Id", "dbo.Items");
            DropIndex("dbo.Transactions", new[] { "Items_Id" });
            DropTable("dbo.Transactions");
        }
    }
}
