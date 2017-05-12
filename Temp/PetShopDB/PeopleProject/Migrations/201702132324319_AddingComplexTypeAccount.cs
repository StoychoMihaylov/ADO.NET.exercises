namespace PeopleProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingComplexTypeAccount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PeopleInformation", "Account_Balance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.PeopleInformation", "Account_MonthRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.PeopleInformation", "Account_AccountNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PeopleInformation", "Account_AccountNumber");
            DropColumn("dbo.PeopleInformation", "Account_MonthRate");
            DropColumn("dbo.PeopleInformation", "Account_Balance");
        }
    }
}
