using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProject.Models
{
    [ComplexType]
    public class Account
    {
        public decimal Balance { get; set; }

        public decimal MonthRate { get; set; }

        public string AccountNumber { get; set; }
    }
}
