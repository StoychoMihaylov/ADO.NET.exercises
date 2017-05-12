using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDB.Models
{
    public class BedType
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Type { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
