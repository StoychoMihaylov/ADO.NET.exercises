using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolDBContext context = new SchoolDBContext();
            // context.Database.Initialize(true);
            Student student = new Student
            {
                Name = "Ivailo",
                Age = 15
            };
            
            context.Students.Add(student);
        }
    }
}
