namespace EntityFrameworkQuaring.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTownId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "Town_Id", "dbo.Towns");
            DropIndex("dbo.People", new[] { "Town_Id" });
            RenameColumn(table: "dbo.People", name: "Town_Id", newName: "TownId");
            AlterColumn("dbo.People", "TownId", c => c.Int(nullable: false));
            CreateIndex("dbo.People", "TownId");
            AddForeignKey("dbo.People", "TownId", "dbo.Towns", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "TownId", "dbo.Towns");
            DropIndex("dbo.People", new[] { "TownId" });
            AlterColumn("dbo.People", "TownId", c => c.Int());
            RenameColumn(table: "dbo.People", name: "TownId", newName: "Town_Id");
            CreateIndex("dbo.People", "Town_Id");
            AddForeignKey("dbo.People", "Town_Id", "dbo.Towns", "Id");
        }
    }
}
