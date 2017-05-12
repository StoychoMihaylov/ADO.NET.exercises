using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSimulator.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        public decimal Price { get; set; }
    }
}
