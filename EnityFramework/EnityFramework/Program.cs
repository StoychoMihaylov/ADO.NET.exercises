using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnityFramework.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();
            using (context)
            {
                //Insert
                //Town town = new Town { Name = "Studentski"};
                //context.Towns.Add(town);
                //context.SaveChanges();

                //Town studentski = context.Towns.FirstOrDefault(town => town.Name == "Studentski");
                //Address mandjasStr = new Address { AddressText = "Mandja, brat"};
                //studentski.Addresses.Add(mandjasStr);
                //context.SaveChanges();

                //Remove
                //Town studentski = context.Towns.FirstOrDefault(town => town.Name == "Studentski");
                //context.Addresses.RemoveRange(studentski.Addresses);
                //or better wey is to change it in NULL
                //foreach (var address in studentski.Addresses)
                //{
                //    address.Town = null;
                //}
                //context.Towns.Remove(studentski);
                //context.SaveChanges();

                //Querying
                //IEnumerable<Address> addresses = context.Addresses;
                //Console.WriteLine();
                //foreach (var address in addresses)
                //{
                //    Console.Write(address.AddressText);

                //}

                //    IEnumerable<Employee> employees = context.Employees
                //        .Where(employee => employee.Projects.Count(project => project.StartDate.Year >= 2001 && project.StartDate.Year <= 2003) > 0)
                //        .Take(30);
                //    foreach (var employee in employees)
                //    {
                //        Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Manager.FirstName}");
                //        foreach (Project project in employee.Projects)
                //        {
                //            Console.WriteLine($"    {project.Name} {project.StartDate} {project.EndDate}");
                //        }
                //    }
                //

                ////Extended proparty from Extensions.Whith that you can to use some properti without it to be write in database

                //Address address = new Address();
                //address.NumberOfCitizens = 1;

                //Employees Full Information

                //IEnumerable<Employee> employees = context.Employees;
                //foreach (var employee in employees)
                //{
                //    Console.WriteLine("{0}, {1}, {2}, {3}, {4}", 
                //        employee.FirstName, employee.LastName, employee.MiddleName,
                //        employee.JobTitle, employee.Salary);
                //}

                //Employees with Salary Over 50 000
                //List<string> employees = context.Employees.Where(emp => emp.Salary >= 50000).Select(emp => emp.FirstName).ToList();
                //foreach (var emp in employees)
                //{
                //    Console.WriteLine(emp);
                //}

                //All Employees from Seattle
                //IEnumerable<Employee> employees = context.Employees
                //    .Where(emp => emp.Department.Name == "Research and Development")
                //    .OrderBy(s => s.Salary)
                //    .ThenByDescending(firstName => firstName.FirstName);
                //foreach (var emp in employees)
                //{
                //    Console.WriteLine($"{emp.FirstName}, {emp.LastName}, {emp.Department.Name}, {emp.Salary}");
                //}

                //Adding a New Address and Updating Employee and print addrestext of top 10 orderby address id
                //var address = new Address() { AddressText= "Vitoshka 15", TownID = 4};
                //var nakovEmployee = context.Employees.First(employee => employee.LastName == "Nakov");
                //nakovEmployee.Address = address;

                //context.SaveChanges();

                //var employeeAddresses = context.Employees.OrderByDescending(emp => emp.Address.AddressID).Take(10)
                //    .Select(emp => emp.Address.AddressText);
                //foreach (var empAddress in employeeAddresses)
                //{
                //    Console.WriteLine(empAddress);
                //}

                //Delete Project by ID
                //Project project = context.Projects.Find(2);
                //ICollection<Employee> employees = project.Employees;
                //foreach (Employee employee in employees)
                //{
                //    employee.Projects.Remove(project);
                //}
                //context.SaveChanges();

                //context.Projects.Remove(project);
                //context.SaveChanges();

                //Find employees in period 
                //var employee = context.Employees
                //    .Where(emp => emp.Projects.Count(prj => prj.StartDate.Year >= 2001 && prj.StartDate.Year <= 2003) > 0)
                //    .Take(30);

                //foreach (var emp in employee)
                //{

                //    Console.WriteLine($"Employee First Name: {emp.FirstName} {emp.LastName} Manager Name: {emp.Manager.FirstName}");
                //    foreach (var proj in emp.Projects)
                //    {
                //        Console.WriteLine($"Project Name: {proj.Name} Start Date: {proj.StartDate} End Date: {proj.EndDate}");
                //    }
                //}

                //Employee with ID147 and his projects
                //var employee = context.Employees.Find(147);
                //Console.WriteLine($"Emplpoyee Name:{employee.FirstName}{employee.LastName}, Job Title:{employee.JobTitle}");
                //foreach (var proj in employee.Projects)
                //{
                //    Console.WriteLine($"Project Name:{proj.Name}");
                //}

                //Departmant with more than 5 employees
                //IEnumerable<Department> departmants = context.Departments
                //    .Where(em => em.Employees.Count > 5)
                //    .OrderBy(dep => dep.Employees.Count);
                //foreach (var dep in departmants)
                //{
                //    Console.WriteLine($"Departmant Name:{dep.Name}, Departmant ManagerName:{dep.Employee.Manager.FirstName}");
                //    foreach (var emp in dep.Employees)
                //    {
                //        Console.WriteLine($"Employee Name:{emp.FirstName}{emp.LastName}, Employee JobTitle:{emp.JobTitle}");
                //    }
                //}
            }
        }
    }
}
