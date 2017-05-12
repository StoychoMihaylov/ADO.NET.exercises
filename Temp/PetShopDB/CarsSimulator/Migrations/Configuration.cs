namespace CarsSimulator.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarsSimulator.CarsDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "CarsSimulator.CarsDBContext";
        }

        protected override void Seed(CarsSimulator.CarsDBContext context)
        {
            
        }
    }
}
