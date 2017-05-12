namespace Ads.Client
{
    using Data;
    using System.Linq;
    using System.Diagnostics;
    using System.IO;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            AdsDBContext context = new AdsDBContext();
            //context.Ads.Count();
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //var ads = context.Ads.Select(ad => ad.Title);
            //foreach (var ad in ads)
            //{
            //    System.Console.WriteLine(ad);
            //}
            //sw.Stop();
            //File.AppendAllText("optimized.txt", sw.Elapsed.ToString() + Environment.NewLine);

            var ads = context.Ads.Where(ad => ad.AdStatus.Status == "Published").ToList();
            foreach (var ad in ads.OrderBy(ad => ad.Date))
            {
                Console.WriteLine($"{ad.Title}, {ad.Category.Name}, {ad.Town.Name}, {ad.Date}");
            }

        }
    }
}
