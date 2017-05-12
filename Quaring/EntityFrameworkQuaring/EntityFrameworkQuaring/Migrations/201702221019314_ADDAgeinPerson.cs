namespace EntityFrameworkQuaring.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADDAgeinPerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Age");
        }
    }
}
