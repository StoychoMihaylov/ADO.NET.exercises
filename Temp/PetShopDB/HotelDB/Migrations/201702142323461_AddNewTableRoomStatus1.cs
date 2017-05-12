namespace HotelDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewTableRoomStatus1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoomStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                        Notes = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RoomStatus");
        }
    }
}
