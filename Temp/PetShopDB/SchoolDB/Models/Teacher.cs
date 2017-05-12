using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB.Models
{
    public class Teacher
    {

        public Teacher()
        {
            this.Students = new HashSet<Student>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
