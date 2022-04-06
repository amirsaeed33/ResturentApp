namespace ResturantApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployeePosition1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeePositions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.String(),
                        Status = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        ComputerLiterate = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "EmployeePositionId", c => c.Byte(nullable: false));
            AddColumn("dbo.Products", "EmployeePosition_Id", c => c.Int());
            CreateIndex("dbo.Products", "EmployeePosition_Id");
            AddForeignKey("dbo.Products", "EmployeePosition_Id", "dbo.EmployeePositions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "EmployeePosition_Id", "dbo.EmployeePositions");
            DropIndex("dbo.Products", new[] { "EmployeePosition_Id" });
            DropColumn("dbo.Products", "EmployeePosition_Id");
            DropColumn("dbo.Products", "EmployeePositionId");
            DropTable("dbo.EmployeePositions");
        }
    }
}
