namespace HotelDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoomTableAndConnectonsWithOtherTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomNumber = c.String(nullable: false, maxLength: 10),
                        Notes = c.String(maxLength: 500),
                        BedType_Id = c.Int(),
                        RoomType_Id = c.Int(),
                        Status_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BedTypes", t => t.BedType_Id)
                .ForeignKey("dbo.RoomTypes", t => t.RoomType_Id)
                .ForeignKey("dbo.RoomStatus", t => t.Status_Id)
                .Index(t => t.BedType_Id)
                .Index(t => t.RoomType_Id)
                .Index(t => t.Status_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "Status_Id", "dbo.RoomStatus");
            DropForeignKey("dbo.Rooms", "RoomType_Id", "dbo.RoomTypes");
            DropForeignKey("dbo.Rooms", "BedType_Id", "dbo.BedTypes");
            DropIndex("dbo.Rooms", new[] { "Status_Id" });
            DropIndex("dbo.Rooms", new[] { "RoomType_Id" });
            DropIndex("dbo.Rooms", new[] { "BedType_Id" });
            DropTable("dbo.Rooms");
        }
    }
}
