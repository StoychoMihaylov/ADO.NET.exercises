
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopDB.Models
{

    public enum Materials
    {
        Wood, Iron, Leather
    }

    public class Cage
    {
        [Key]
        [Column(Order = 1)]   
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Notes { get; set; }

        public bool IsEmpty { get; set; }

        public Materials Material { get; set; }
    }
}
