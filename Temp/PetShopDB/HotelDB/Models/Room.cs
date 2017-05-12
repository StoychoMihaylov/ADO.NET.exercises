using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDB.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(10)]
        public string RoomNumber { get; set; }

        public RoomType RoomType { get; set; }

        public BedType BedType { get; set; }

        [StringLength(20)]
        public string Rate { get; set; }

        public RoomStatus Status { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }
    }
}
