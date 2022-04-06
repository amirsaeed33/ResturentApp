namespace ResturantApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePaymentType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PaymentTypes (Name) VALUES ('Cash')");
            Sql("INSERT INTO PaymentTypes (Name) VALUES ('Transfer')");
            Sql("INSERT INTO PaymentTypes (Name) VALUES ('POS')");

        }

        public override void Down()
        {
        }
    }
}
