namespace ResturantApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "EmployeePositionId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "EmployeePositionId");
        }
    }
}
