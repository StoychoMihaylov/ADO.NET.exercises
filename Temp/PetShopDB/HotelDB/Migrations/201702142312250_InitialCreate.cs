namespace HotelDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        AccountNumber = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        PhoneNumber = c.String(maxLength: 10),
                        EmergencyName = c.String(nullable: false, maxLength: 20),
                        EmergencyNumber = c.String(nullable: false, maxLength: 20),
                        Notes = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => new { t.Id, t.AccountNumber });
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Title = c.String(nullable: false, maxLength: 50),
                        Notes = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
        }
    }
}
