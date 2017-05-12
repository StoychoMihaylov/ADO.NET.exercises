using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSimulator.Models
{
    [Table("Batmobiles")]
    public class Batmobile : Car
    {
        public int NumberOfWings { get; set; }

        public string Logo { get; set; }
    }
}
