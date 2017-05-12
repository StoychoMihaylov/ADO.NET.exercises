namespace TestRelation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTown : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Towns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CountryName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "BornTown_Id", c => c.Int());
            AddColumn("dbo.Students", "LivingTown_Id", c => c.Int());
            CreateIndex("dbo.Students", "BornTown_Id");
            CreateIndex("dbo.Students", "LivingTown_Id");
            AddForeignKey("dbo.Students", "BornTown_Id", "dbo.Towns", "Id");
            AddForeignKey("dbo.Students", "LivingTown_Id", "dbo.Towns", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "LivingTown_Id", "dbo.Towns");
            DropForeignKey("dbo.Students", "BornTown_Id", "dbo.Towns");
            DropIndex("dbo.Students", new[] { "LivingTown_Id" });
            DropIndex("dbo.Students", new[] { "BornTown_Id" });
            DropColumn("dbo.Students", "LivingTown_Id");
            DropColumn("dbo.Students", "BornTown_Id");
            DropTable("dbo.Towns");
        }
    }
}
