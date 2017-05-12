using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Models
{
    public class Town
    {
        public Town()
        {
            this.People = new HashSet<Person>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
