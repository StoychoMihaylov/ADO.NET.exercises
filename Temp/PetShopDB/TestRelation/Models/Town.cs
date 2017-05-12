using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRelation.Models
{
    public class Town
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string CountryName { get; set; }

        [InverseProperty("BornTown")]
        public virtual ICollection<Student> BornStudents { get; set; }

        [InverseProperty("LivingTown")]
        public virtual ICollection<Student> LivingStudents { get; set; }
    }
}
