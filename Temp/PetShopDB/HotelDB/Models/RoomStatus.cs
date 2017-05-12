using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDB.Models
{
    public class RoomStatus
    {
        [Key]
        public int Id { get; set; }

        [Required, Range(0,1)]
        public int Status { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
