namespace HotelDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablePayment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaymentDate = c.DateTime(nullable: false),
                        FirstDateOccupied = c.DateTime(nullable: false),
                        LastDateOccupied = c.DateTime(nullable: false),
                        TotalDays = c.String(),
                        AmountCharged = c.String(maxLength: 20),
                        TaxRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TaxAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Notes = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Rooms", "Rate", c => c.String(maxLength: 20));
            CreateIndex("dbo.Customers", "Id");
            AddForeignKey("dbo.Customers", "Id", "dbo.Payments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Id", "dbo.Payments");
            DropIndex("dbo.Customers", new[] { "Id" });
            DropColumn("dbo.Rooms", "Rate");
            DropTable("dbo.Payments");
        }
    }
}
