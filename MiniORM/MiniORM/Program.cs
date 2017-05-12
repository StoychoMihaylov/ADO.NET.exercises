using MiniORM.Entities;
using System;

namespace MiniORM
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = new ConnectionStringBuilder("MyWebSiteDatabase").ConnectionString;
            IDbContext context = new EntityManager(connectionString, true);

            User user = new User("Gosho", "asd", 12, DateTime.Now);
            context.Persist(user);
        }
    }
}
