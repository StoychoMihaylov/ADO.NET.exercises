namespace TestRelation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        School_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schools", t => t.School_Id)
                .Index(t => t.School_Id);
            
            CreateTable(
                "dbo.StudentAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentAddresses", "Id", "dbo.Students");
            DropForeignKey("dbo.Students", "School_Id", "dbo.Schools");
            DropIndex("dbo.StudentAddresses", new[] { "Id" });
            DropIndex("dbo.Students", new[] { "School_Id" });
            DropTable("dbo.StudentAddresses");
            DropTable("dbo.Students");
            DropTable("dbo.Schools");
        }
    }
}
