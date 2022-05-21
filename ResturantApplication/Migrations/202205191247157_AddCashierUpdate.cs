namespace ResturantApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCashierUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cashiers", "Photo", c => c.String());
            AddColumn("dbo.Cashiers", "NameOfNextOfKin", c => c.String());
            AddColumn("dbo.Cashiers", "NextOfKinPhoneNumber", c => c.String());
            AddColumn("dbo.Cashiers", "NextOfKinRelation", c => c.String());
            AddColumn("dbo.Cashiers", "PermanentAddress", c => c.String());
            AddColumn("dbo.Cashiers", "LGA", c => c.String());
            AddColumn("dbo.Cashiers", "StateOfOrigin", c => c.String());
            AddColumn("dbo.Cashiers", "ContactAddress", c => c.String());
            AlterColumn("dbo.Cashiers", "PhoneNumber", c => c.String(maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cashiers", "PhoneNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Cashiers", "ContactAddress");
            DropColumn("dbo.Cashiers", "StateOfOrigin");
            DropColumn("dbo.Cashiers", "LGA");
            DropColumn("dbo.Cashiers", "PermanentAddress");
            DropColumn("dbo.Cashiers", "NextOfKinRelation");
            DropColumn("dbo.Cashiers", "NextOfKinPhoneNumber");
            DropColumn("dbo.Cashiers", "NameOfNextOfKin");
            DropColumn("dbo.Cashiers", "Photo");
        }
    }
}
