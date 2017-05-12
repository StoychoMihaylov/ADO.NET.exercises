namespace GringottsDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WizardDeposits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 60),
                        Notes = c.String(maxLength: 1000),
                        Age = c.Int(nullable: false),
                        MagicWandCreator = c.String(maxLength: 100),
                        MagicWandSize = c.Int(nullable: false),
                        DepositGroup = c.String(maxLength: 20),
                        DeoisutStartDate = c.DateTime(nullable: false),
                        DepositAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DepositInterest = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DepositCharge = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DepositExpirationDate = c.DateTime(nullable: false),
                        IsDepositExpired = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WizardDeposits");
        }
    }
}
