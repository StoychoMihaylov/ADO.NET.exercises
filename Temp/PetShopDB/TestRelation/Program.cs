using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRelation.Models;

namespace TestRelation
{
    class Program
    {
        static void Main(string[] args)
        {
            WorldDBContext context = new WorldDBContext();
            context.Subjects.Add(new Subject() { Name = "Math" });
            context.Subjects.Add(new Subject() { Name = "History"});

            context.SaveChanges();

            IEnumerable<Student> students = context.Students;
            foreach (var student in students)
            {
                context.Subjects.First(subj => subj.Name == "Math").Students.Add(student);
                context.Subjects.First(subj => subj.Name == "History").Students.Add(student);
            }
            context.SaveChanges();
        }
    }
}
