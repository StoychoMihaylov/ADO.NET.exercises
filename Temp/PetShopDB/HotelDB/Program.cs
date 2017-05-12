using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDB
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelDBContext context = new HotelDBContext();
            context.Database.Initialize(true);
        }
    }
}
