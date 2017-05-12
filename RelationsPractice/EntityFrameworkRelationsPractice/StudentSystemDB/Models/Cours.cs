using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemDB.Models
{
    public class Cours
    {
        public Cours()
        {
            this.Students = new HashSet<Student>();
            this.Resourses = new HashSet<Resource>();
            this.Homeworks = new HashSet<Homework>();
        }

        [Key]
        public int Id { get; set; }

        [Required,StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Resource> Resourses { get; set; }

        public virtual ICollection<Homework> Homeworks { get; set; }
    }
}
