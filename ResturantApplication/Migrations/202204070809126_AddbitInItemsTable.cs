namespace ResturantApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddbitInItemsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "MinQty", c => c.Int(nullable: false));
            AddColumn("dbo.Items", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Items", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "IsDeleted");
            DropColumn("dbo.Items", "IsActive");
            DropColumn("dbo.Items", "MinQty");
        }
    }
}
