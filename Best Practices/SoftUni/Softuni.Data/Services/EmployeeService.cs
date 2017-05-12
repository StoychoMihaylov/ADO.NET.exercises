using Softuni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softuni.Data.Services
{
    public class EmployeeService
    {
        private readonly UnitOfWork unit;

        public EmployeeService(UnitOfWork unit)
        {
            this.unit = unit;
        }

        public Employee GetEmployeeByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name), "Name shuld not be null or empty!");
            }
            return this.unit.Employees.Find(employee => employee.FirstName == name).FirstOrDefault();
        }
    }
}
