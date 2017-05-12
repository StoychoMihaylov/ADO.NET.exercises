using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemDB.Models
{
    public class Resource
    {
        public Resource()
        {
            this.Licenses = new HashSet<Licens>();
        }

        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required]
        public string ResourceType { get; set; }

        [Required]
        public string URL { get; set; }

        public virtual Cours Courses { get; set; }

        public virtual ICollection<Licens> Licenses { get; set; }
    }
}
