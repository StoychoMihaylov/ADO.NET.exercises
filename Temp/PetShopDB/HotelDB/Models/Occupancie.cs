using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDB.Models
{
    public class Occupancie
    {
        [Key]
        public int Id { get; set; }

        
        public DateTime DateOccupied { get; set; }

        public Customer AccountNumber { get; set; }

        public Room RoomNumber { get; set; }

        public decimal RateApplied { get; set; }

        [StringLength(20)]
        public string PhoneCharge { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }
    }
}
