namespace PeopleProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PeopleProject.PeopleDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "PeopleProject.PeopleDBContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(PeopleProject.PeopleDBContext context)
        {
           
        }
    }
}
