using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDB.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

       
        public ICollection<Customer> AccountNumber { get; set; }

        public DateTime FirstDateOccupied { get; set; }

        public DateTime LastDateOccupied { get; set; }

        public string TotalDays { get; set; }

        [StringLength(20)]
        public string AmountCharged { get; set; }

        public decimal TaxRate { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal PaymentTotal { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }
    }
}
