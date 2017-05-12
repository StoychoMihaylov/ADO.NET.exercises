using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDB.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string FirstName { get; set; }

        [Required, MaxLength(20)]
        public string LastName { get; set; }

        [Required, MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Notes { get; set; }
    }
}
