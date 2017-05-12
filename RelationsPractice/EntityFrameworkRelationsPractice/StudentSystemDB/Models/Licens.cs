using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemDB.Models
{
    public class Licens
    {
        [Key]
        public int Id { get; set; }

        [StringLength(10)]
        public string Name { get; set; }

        public virtual Resource Resources { get; set; }
    }
}
