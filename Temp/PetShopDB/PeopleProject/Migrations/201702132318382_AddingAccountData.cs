namespace PeopleProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingAccountData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PeopleInformation", "Balance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.PeopleInformation", "MonthRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.PeopleInformation", "AccountNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PeopleInformation", "AccountNumber");
            DropColumn("dbo.PeopleInformation", "MonthRate");
            DropColumn("dbo.PeopleInformation", "Balance");
        }
    }
}
