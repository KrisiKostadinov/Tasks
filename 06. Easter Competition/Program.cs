using System;

namespace _06._Easter_Competition
{
    class Program
    {
        static void Main()
        {
            int breadCount = int.Parse(Console.ReadLine());

            int currentPointsBaker = 0;
            int maxPoints = 0;
            string currentBaker = "";
            string bestBaker = "";

            for (int i = 0; i < breadCount; i++)
            {
                currentBaker = Console.ReadLine();

                currentPointsBaker = 0;

                while (currentBaker != "Stop")
                {
                    bool isNotStop = int.TryParse(Console.ReadLine(), out int points);

                    if (!isNotStop)
                    {
                        Console.WriteLine($"{currentBaker} has {currentPointsBaker} points.");
                        Console.WriteLine($"{currentBaker} is the new number 1!");
                        break;
                    }

                    currentPointsBaker += points;

                    if (currentPointsBaker > maxPoints)
                    {
                        maxPoints = currentPointsBaker;
                        bestBaker = currentBaker;
                    }
                }
            }
            Console.WriteLine($"{bestBaker} won competition with {maxPoints} points!");
        }
    }
}
