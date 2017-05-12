using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDB.Models
{
    public class Customer
    {
        [Key, Column(Order = 1)]
        public int Id { get; set; }

        [Key, Column(Order = 2)]
        public int AccountNumber { get; set; }

        [Required, MaxLength(20)]
        public string FirstName { get; set; }

        [Required, MaxLength(20)]
        public string LastName { get; set; }

        [MaxLength(10)]
        public string PhoneNumber { get; set; }

        [Required, MaxLength(20)]
        public string EmergencyName { get; set; }

        [Required, MaxLength(20)]
        public string EmergencyNumber { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        public ICollection<Occupancie> Occupancies { get; set; }
    }
}
