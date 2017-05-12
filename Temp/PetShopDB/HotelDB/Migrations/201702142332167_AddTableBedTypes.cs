namespace HotelDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableBedTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BedTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 20),
                        Notes = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoomTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 20),
                        Notes = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RoomTypes");
            DropTable("dbo.BedTypes");
        }
    }
}
