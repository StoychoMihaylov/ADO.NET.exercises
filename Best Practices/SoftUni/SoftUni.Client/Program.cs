using Softuni.Data;
using Softuni.Data.Contract;
using Softuni.Data.Repositories;
using Softuni.Data.Services;
using Softuni.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork work = new UnitOfWork();

            EmployeeService sercive = new EmployeeService(work);
        }
    }
}
