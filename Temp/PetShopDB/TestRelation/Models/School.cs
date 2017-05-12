using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRelation.Models;

namespace TestRelation.Models
{
    public class School
    {   
        public School()
        {
            this.Students = new HashSet<Student>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
