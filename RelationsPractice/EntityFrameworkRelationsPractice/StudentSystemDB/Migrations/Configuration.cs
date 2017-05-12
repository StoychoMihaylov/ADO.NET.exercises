namespace StudentSystemDB.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentSystemDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "StudentSystemDB.StudentSystemDBContext";
        }

        protected override void Seed(StudentSystemDBContext context)
        {
            Cours cours1 = new Cours()
            {
                Name = "C# Programming",
                Description = "Programming on VS with C# language",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(2),
                Price = 250M,
            };
            Cours cours2 = new Cours()
            {
                Name = "Java Programming",
                Description = "Programming on Inteligai with Java language",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(2),
                Price = 250M,
                
            };
            Resource resource = new Resource()
            {
                Name = "Books for C#",
                ResourceType = "Text.Dokument",
                URL = "www.something.com"
            };
            Resource resource2 = new Resource()
            {
                Name = "Books for Java",
                ResourceType = "Text.Dokument",
                URL = "www.something.com"
            };
            Student stoycho = new Student()
            {
                Name = "Stoycho",
                PhoneNumber = "0896217764",
                RegistraredOnDate = DateTime.Now,
                birthDay = new DateTime(1992,02,24)
            };
            Student gosho = new Student()
            {
                Name = "Gosho",
                PhoneNumber = "089645764",
                RegistraredOnDate = DateTime.Now,
                birthDay = new DateTime(1992,4,10)
            };
            Student pesho = new Student()
            {
                Name = "Pesho",
                PhoneNumber = "089644564",
                RegistraredOnDate = DateTime.Now,
                birthDay = new DateTime(1992,9,2)
            };
            Student mincho = new Student()
            {
                Name = "Mincho",
                PhoneNumber = "0896444521",
                RegistraredOnDate = DateTime.Now,
                birthDay = new DateTime(1992,04,20)
            };
            context.Students.Add(mincho);
            context.Courses.Add(cours1);
            context.Courses.Add(cours2);
            context.Resources.Add(resource);
            context.Resources.Add(resource2);
            context.Students.Add(gosho);
            context.Students.Add(stoycho);
            context.Students.Add(pesho);
            context.SaveChanges();

            IEnumerable<Student> students = context.Students;           
            foreach (var student in students)
            {
                context.Courses.First(c => c.Name == "C# Programming").Students.Add(student);
                context.Courses.First(c => c.Name == "Java Programming").Students.Add(student);
            }
            var resours = context.Resources.FirstOrDefault(res => res.Name == "Books for C#");
            context.Courses.First(res => res.Name == "C# Programming").Resourses.Add(resours);
            var resours2 = context.Resources.FirstOrDefault(res => res.Name == "Books for Java");
            context.Courses.First(res => res.Name == "Java Programming").Resourses.Add(resours2);
            context.SaveChanges();

            Homework homework = new Homework()
            {
                Content = "This is my homerowk",
                ContentType = "exrercise",
                SubmissionDate = DateTime.Now,
            };
            context.Homeworks.Add(homework);
            Homework homework2 = new Homework()
            {
                Content = "This is my homerowk",
                ContentType = "exrercise",
                SubmissionDate = DateTime.Now,
            };
            context.Homeworks.Add(homework2);
            Homework homework3 = new Homework()
            {
                Content = "This is my homerowk",
                ContentType = "exrercise",
                SubmissionDate = DateTime.Now,
            };
            context.SaveChanges();

            context.Students.FirstOrDefault(stud => stud.Name == "Stoycho").Homeworks.Add(homework);
            context.Students.FirstOrDefault(stud => stud.Name == "Pesho").Homeworks.Add(homework2);
            context.Students.FirstOrDefault(stud => stud.Name == "Mincho").Homeworks.Add(homework3);
            context.SaveChanges();

            context.Courses.FirstOrDefault(res => res.Name == "C# Programming").Resourses.Add(new Resource()
            {
                Name = "Loops",
                ResourceType = "Book",
                URL = "google"
            });
            context.Courses.FirstOrDefault(res => res.Name == "C# Programming").Resourses.Add(new Resource()
            {
                Name = "Arrays",
                ResourceType = "Book",
                URL = "google"
            });
            context.Courses.FirstOrDefault(res => res.Name == "C# Programming").Resourses.Add(new Resource()
            {
                Name = "Algorithms",
                ResourceType = "Book",
                URL = "google"
            });
            context.Courses.FirstOrDefault(res => res.Name == "C# Programming").Resourses.Add(new Resource()
            {
                Name = "Dictionaryties",
                ResourceType = "Book",
                URL = "google"
            });
            context.Courses.FirstOrDefault(res => res.Name == "C# Programming").Resourses.Add(new Resource()
            {
                Name = "Methods",
                ResourceType = "Book",
                URL = "google"
            });
            context.SaveChanges();

            Cours cours10 = new Cours()
            {
                Name = "C# Programming",
                Description = "Programming on VS with C# language",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(2),
                Price = 150M,
            };
            Cours cours11 = new Cours()
            {
                Name = "C# Programming",
                Description = "Programming on VS with C# language",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(2),
                Price = 230M,
            };
            Cours cours12 = new Cours()
            {
                Name = "C# Programming",
                Description = "Programming on VS with C# language",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(2),
                Price = 130M,
            };
            Cours cours13 = new Cours()
            {
                Name = "C# Programming",
                Description = "Programming on VS with C# language",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(2),
                Price = 350M,
            };
            context.Courses.Add(cours10);
            context.Courses.Add(cours11);
            context.Courses.Add(cours12);
            context.Courses.Add(cours13);
            context.SaveChanges();

            context.Students.FirstOrDefault(stud => stud.Name == "Stoycho").Courses.Add(cours10);
            context.Students.FirstOrDefault(stud => stud.Name == "Pesho").Courses.Add(cours10);
            context.Students.FirstOrDefault(stud => stud.Name == "Mincho").Courses.Add(cours10);
            context.Students.FirstOrDefault(stud => stud.Name == "Stoycho").Courses.Add(cours11);
            context.Students.FirstOrDefault(stud => stud.Name == "Pesho").Courses.Add(cours11);
            context.Students.FirstOrDefault(stud => stud.Name == "Mincho").Courses.Add(cours11);
            context.Students.FirstOrDefault(stud => stud.Name == "Stoycho").Courses.Add(cours12);
            context.Students.FirstOrDefault(stud => stud.Name == "Pesho").Courses.Add(cours12);
            context.Students.FirstOrDefault(stud => stud.Name == "Mincho").Courses.Add(cours12);
            context.Students.FirstOrDefault(stud => stud.Name == "Stoycho").Courses.Add(cours13);
            context.Students.FirstOrDefault(stud => stud.Name == "Pesho").Courses.Add(cours13);
            context.Students.FirstOrDefault(stud => stud.Name == "Mincho").Courses.Add(cours13);
            context.SaveChanges();
        }
    }
}
