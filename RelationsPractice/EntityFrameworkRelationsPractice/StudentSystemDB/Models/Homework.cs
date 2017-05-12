using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemDB.Models
{
    public class Homework
    {
        [Key]
        public int Id { get; set; }

        [StringLength(500)]
        public string Content { get; set; }

        [StringLength(50)]
        public string ContentType { get; set; }

        public DateTime SubmissionDate { get; set; }

        public virtual Student Student { get; set; }
    }
}
