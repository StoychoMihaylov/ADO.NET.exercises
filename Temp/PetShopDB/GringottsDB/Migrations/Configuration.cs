namespace GringottsDB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GringottsDB.GringottsDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "GringottsDB.GringottsDBContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(GringottsDB.GringottsDBContext context)
        {
            
        }
    }
}
