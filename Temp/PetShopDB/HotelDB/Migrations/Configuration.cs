namespace HotelDB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HotelDB.HotelDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "HotelDB.HotelDBContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(HotelDB.HotelDBContext context)
        {
           
        }
    }
}
