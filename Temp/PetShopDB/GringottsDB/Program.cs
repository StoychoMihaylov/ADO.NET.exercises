using GringottsDB.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GringottsDB
{
    class Program
    {
        static void Main(string[] args)
        {
            User newuser = new User()
            {
                Username = "Petrohan",
                Password = "A231b2gg^^!",
                Email = "petrohan@abv.bg",
                ProfilePicture = File.ReadAllBytes("C:\\Users\\Stoycho\\Desktop\\profile.jpg"),
                RegisteredOn = DateTime.Now,
                LastTimeLoggedIn = DateTime.Now,
                Age = 100,
                IsDeleted = false
            };

            GringottsDBContext context = new GringottsDBContext();
            context.Users.Add(newuser);
            context.SaveChanges();
        }
    }
}
