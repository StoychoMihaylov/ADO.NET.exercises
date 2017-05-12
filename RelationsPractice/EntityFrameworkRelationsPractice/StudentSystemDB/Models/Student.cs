using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemDB.Models
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<Cours>();
            this.Homeworks = new HashSet<Homework>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime RegistraredOnDate { get; set; }

        public DateTime birthDay { get; set; }

        public virtual ICollection<Cours> Courses { get; set; }

        public virtual ICollection<Homework> Homeworks { get; set; }
    }
}
