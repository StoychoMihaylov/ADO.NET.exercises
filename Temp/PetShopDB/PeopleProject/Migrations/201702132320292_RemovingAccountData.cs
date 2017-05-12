namespace PeopleProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingAccountData : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PeopleInformation", "Balance");
            DropColumn("dbo.PeopleInformation", "MonthRate");
            DropColumn("dbo.PeopleInformation", "AccountNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PeopleInformation", "AccountNumber", c => c.String());
            AddColumn("dbo.PeopleInformation", "MonthRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.PeopleInformation", "Balance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
