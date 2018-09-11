using System;
using System.Collections.Generic;

namespace CarSetHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> ShowRoom = new HashSet<string>();
            ShowRoom.Add("Saab Viggen");
            ShowRoom.Add("Subaru WRX");
            ShowRoom.Add("Tesla Model S");
            ShowRoom.Add("Saturn Ion");
            ShowRoom.Add("Saturn Ion");

            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Audi A4");
            UsedLot.Add("Honda Civic");

            ShowRoom.UnionWith(UsedLot);

            ShowRoom.Remove("Tesla Model S");

            HashSet<string> Junkyard = new HashSet<string>()
            {
                "Saturn Ion",
                "Volvo P-1800",
                "Saab Viggen",
                "Volkswagen Jetta",
                "Kia Optima",
                "Saab 9-3"
            };

            ShowRoom.UnionWith(Junkyard);
            ShowRoom.Remove("Kia Optima");

            Console.WriteLine($"I have {ShowRoom.Count} cars.");
            Console.ReadLine();
        }
    }
}
