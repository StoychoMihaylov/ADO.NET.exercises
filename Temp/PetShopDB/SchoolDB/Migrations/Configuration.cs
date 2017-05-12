namespace SchoolDB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SchoolDB.SchoolDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "SchoolDB.SchoolDBContext";
            AutomaticMigrationDataLossAllowed = true;//Pozvolqva da triem poleta ili tablici v bazata
        }

        protected override void Seed(SchoolDB.SchoolDBContext context)
        {
           
        }
    }
}
