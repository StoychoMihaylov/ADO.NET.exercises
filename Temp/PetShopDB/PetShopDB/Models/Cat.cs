using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopDB.Models
{
    public class Cat
    {
        private string stockName;

        [Key]
        public int Id { get; set; }

        [Index(IsUnique = true)]
        [Required]
        public string StockName
        {
            get { return this.stockName; }
            set
            {
                if (value == null)
                {
                    throw new Exception("stockName cannot be null");
                }

                this.stockName = value;
            }
        }

        public string Breed { get; set; }
    }
}
