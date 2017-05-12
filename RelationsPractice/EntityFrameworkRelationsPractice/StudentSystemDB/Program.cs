using StudentSystemDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemDB
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentSystemDBContext context = new StudentSystemDBContext();
            //IEnumerable<Student> students = context.Students;
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"{student.Name}");
            //    foreach (var homework in student.Homeworks)
            //    {
            //        Console.WriteLine($"{homework.Content},{homework.ContentType}");
            //    }
            //}

            //IEnumerable<Cours> courses = context.Courses;
            //foreach (var cours in courses.OrderBy(cours => cours.StartDate).ThenBy(c => c.EndDate))
            //{
            //    Console.WriteLine($"{cours.Name}, {cours.Description}");
            //    foreach (var resours in cours.Resourses)
            //    {
            //        Console.WriteLine($"{resours.Name}, {resours.ResourceType}, {resours.URL}");
            //    }
            //}

            //IEnumerable<Cours> courses = context.Courses
            //    .Where(c => c.Resourses.Count() > 5)
            //    .OrderByDescending(c => c.Resourses.Count())
            //    .ThenByDescending(c => c.StartDate);

            //foreach (var cours in courses)
            //{
            //    Console.WriteLine($"{cours.Name}, {cours.Resourses.Count()}");

            //}

            //IEnumerable<Cours> courses = context.Courses.Where(c => c.StartDate < DateTime.Now && c.EndDate > DateTime.Now);
            //foreach (var cours in courses)
            //{
            //    Console.WriteLine($"{cours.Name}, {cours.Students.Count()}");
            //}

            IEnumerable<Student> students = context.Students;
            foreach (var student in students.OrderBy(s => s.Courses.Max()))
            {
                decimal totalPrice = 0.0M;
                List<decimal> avg = new List<decimal>();
                foreach (var cours in student.Courses)
                {
                    totalPrice += cours.Price;
                    avg.Add(cours.Price);
                }

                Console.WriteLine($"{student.Name}, {student.Courses.Count()}, {totalPrice}, {avg.Average()}");
            }

        }
    }
}
