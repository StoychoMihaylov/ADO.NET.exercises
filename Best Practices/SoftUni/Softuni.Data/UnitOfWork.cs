using Softuni.Data.Contract;
using Softuni.Data.Repositories;
using Softuni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softuni.Data
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly SoftuniContext context = new SoftuniContext();

        private IRepository<Employee> employees;
        private IRepository<Address> adresses;
        private IRepository<Town> towns;
        private IRepository<Department> departments;
        private IRepository<Project> projects;

        public IRepository<Employee> Employees
        {
            get
            {
                return employees ?? (this.employees = new Repository<Employee>(this.context));
            }
        }

        public IRepository<Address> Adresses
        {
            get
            {
                return adresses ?? (this.adresses = new Repository<Address>(this.context));
            }
        }

        public IRepository<Town> Towns
        {
            get
            {
                return towns ?? (this.towns = new Repository<Town>(this.context));
            }
        }

        public IRepository<Department> Departments
        {
            get
            {
                return departments ?? (this.departments = new Repository<Department>(this.context));
            }
        }

        public IRepository<Project> Projects
        {
            get
            {
                return projects ?? (this.projects = new Repository<Project>(this.context));
            }
        }

        public void Save()
        {
            this.context.SaveChanges();
        }
    }
}
