using System;
using Kfz.Core.DataAccess;

namespace Kfz.Core.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            KfzContext kfzContext = new KfzContext();
            kfzContext.Database.EnsureCreated();

            var vehicles = kfzContext.Vehicle;
            Console.WriteLine(@"Kennzeichen\tHersteller\tModell");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.LicenceNumber}\t{vehicle.Manufacturer}\t{vehicle.Model}");
            }
        }
    }
}
