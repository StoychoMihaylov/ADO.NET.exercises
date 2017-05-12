using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRelation.Models
{
     public class StudentAddress
    {
        [ForeignKey("Student")]
        public int Id { get; set; }

        [Required]
        public string Address { get; set; }

        public Student Student { get; set; } //it's navigation property

    }
}
