using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSimulator.Models
{
    [Table("LuxuriosCars")]
    class LuxuriosCar : Car
    {
        public int LitersOfChampagne { get; set; }

        public string HotTubeModel { get; set; }
    }
}
