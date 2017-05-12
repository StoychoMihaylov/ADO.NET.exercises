using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GringottsDB.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MinLength(4), MaxLength(30), Required]
        public string Username { get; set; }

        [Required, MinLength(6), MaxLength(50), RegularExpression(@"^(?=.*[0-9]).{1,}$")]
        public string Password { get; set; }

        [Required, RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")]
        public string Email { get; set; }

        [MaxLength(1024*1024)]
        public byte[] ProfilePicture { get; set; }

        public DateTime RegisteredOn { get; set; }

        public DateTime LastTimeLoggedIn { get; set; }

        [Range(1,120)]
        public int Age { get; set; }

        public bool IsDeleted { get; set; }
    }
}
