namespace PeopleProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PeopleTableRename : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.People", newName: "PeopleInformation");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.PeopleInformation", newName: "People");
        }
    }
}
