using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GringottsDB.Models
{
    public class WizardDeposit
    {
        private int age;

        [Key]
        public int Id { get; set; }

        [MaxLength(50), Required]
        public string FirstName { get; set; }

        [MaxLength(60), Required]
        public string LastName { get; set; }

        [MaxLength(1000)]
        public string Notes { get; set; }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Age cannot be negative number");
                }

                this.age = value;
            }
        }

        [MaxLength(100)]
        public string MagicWandCreator { get; set; }

        [Range(1, 2000)]
        public int MagicWandSize { get; set; }

        [MaxLength(20)]
        public string DepositGroup { get; set; }

        public DateTime DeoisutStartDate { get; set; }

        public decimal DepositAmount { get; set; }

        public decimal DepositInterest { get; set; }

        public decimal DepositCharge { get; set; }

        public DateTime DepositExpirationDate { get; set; }

        public bool IsDepositExpired { get; set; }
    }
}
