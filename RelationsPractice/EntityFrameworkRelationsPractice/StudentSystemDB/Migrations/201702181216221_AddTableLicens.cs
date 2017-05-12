namespace StudentSystemDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableLicens : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Licens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 10),
                        Resources_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Resources", t => t.Resources_Id)
                .Index(t => t.Resources_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Licens", "Resources_Id", "dbo.Resources");
            DropIndex("dbo.Licens", new[] { "Resources_Id" });
            DropTable("dbo.Licens");
        }
    }
}
