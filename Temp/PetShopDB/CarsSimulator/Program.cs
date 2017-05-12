using CarsSimulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarsDBContext context = new CarsDBContext();
            context.Cars.Add(new Batmobile()
            {
                Logo = "iBat",
                Manufacturer = "Lada",
                Model = "Special",
                NumberOfWings = 2,
                Price = 2000.92M
            });
            context.Cars.Add(new LuxuriosCar()
            {
                Manufacturer = "FakeCompany",
                Model = "Taxi",
                Price = 10.30M,
                HotTubeModel = "Night",
                LitersOfChampagne = 2
            });
            //context.Cars.OfType<LuxuriosCar>().First();
            context.SaveChanges();
        }
    }
}
