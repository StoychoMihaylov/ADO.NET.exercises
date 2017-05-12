namespace PeopleProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddoverridePropertyInDBContext : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PeopleInformation", "FirstName", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PeopleInformation", "FirstName", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
