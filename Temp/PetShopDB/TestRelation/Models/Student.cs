using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRelation.Models
{
    public class Student
    {
        public Student()
        {
            this.Subjects = new HashSet<Subject>();
            this.Friends = new HashSet<Student>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual StudentAddress StudentAddress { get; set; }

        public virtual School School { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }

        public virtual ICollection<Student> Friends { get; set; }

        public virtual Town BornTown { get; set; }

        public virtual Town LivingTown { get; set; }
    }
}
