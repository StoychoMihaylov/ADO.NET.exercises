namespace PeopleProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveAccountFromPerson : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PeopleInformation", "Account_Balance");
            DropColumn("dbo.PeopleInformation", "Account_MonthRate");
            DropColumn("dbo.PeopleInformation", "Account_AccountNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PeopleInformation", "Account_AccountNumber", c => c.String());
            AddColumn("dbo.PeopleInformation", "Account_MonthRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.PeopleInformation", "Account_Balance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
