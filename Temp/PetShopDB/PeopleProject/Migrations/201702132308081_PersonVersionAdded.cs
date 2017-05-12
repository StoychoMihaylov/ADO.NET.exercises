namespace PeopleProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonVersionAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PeopleInformation", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PeopleInformation", "Version");
        }
    }
}
