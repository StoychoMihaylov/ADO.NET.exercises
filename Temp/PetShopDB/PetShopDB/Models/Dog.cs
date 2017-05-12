using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopDB.Models
{
    public class Dog
    {
        [Key]
        public int Id { get; set; }

        public string StockName { get; set; }

        public string Breed { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
