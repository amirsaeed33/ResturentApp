namespace ResturantApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToItemsNames : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Names", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Names", c => c.String());
        }
    }
}
