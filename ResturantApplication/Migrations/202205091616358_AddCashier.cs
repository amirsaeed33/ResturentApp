namespace ResturantApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCashier : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cashiers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Position = c.String(),
                        Gender = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        EmailAddress = c.String(),
                        ComputerLiterate = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cashiers");
        }
    }
}
