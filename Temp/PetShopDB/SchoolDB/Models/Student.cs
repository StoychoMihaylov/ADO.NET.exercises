using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("StudentName", TypeName = "varchar")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Range(0, 150)]
        public int Age { get; set; }

        public Teacher Teacher { get; set; }
    }
}
