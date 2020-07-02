using System;

namespace _03._Easter_Trip
{
    class Program
    {
        static void Main()
        {
            string destionation = Console.ReadLine();
            string dates = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double sum = 0;

            switch (destionation)
            {
                case "Germany":
                    switch (dates)
                    {
                        case "21-23": sum = nightsCount * 32; break;
                        case "24-27": sum = nightsCount * 37; break;
                        case "28-31": sum = nightsCount * 43; break;
                    }
                    break;
                case "Italy":
                    switch (dates)
                    {
                        case "21-23": sum = nightsCount * 28; break;
                        case "24-27": sum = nightsCount * 32; break;
                        case "28-31": sum = nightsCount * 39; break;
                    }
                    break;
                case "France":
                    switch (dates)
                    {
                        case "21-23": sum = nightsCount * 30; break;
                        case "24-27": sum = nightsCount * 35; break;
                        case "28-31": sum = nightsCount * 40; break;
                    }
                    break;
            }

            Console.WriteLine($"Easter trip to {destionation} : {sum:F2} leva.");
        }
    }
}
