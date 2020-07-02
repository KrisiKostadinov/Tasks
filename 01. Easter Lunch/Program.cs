using System;

namespace _01._Easter_Lunch
{
    class Program
    {
        static void Main()
        {
            int breadsCount = int.Parse(Console.ReadLine());
            int eggsBoardCount = int.Parse(Console.ReadLine());
            int biscuitsCount = int.Parse(Console.ReadLine());

            decimal bread = 3.20m * breadsCount;
            decimal egg = 4.35m * eggsBoardCount;
            decimal biscuits = 5.40m * biscuitsCount;
            decimal paintEggs = eggsBoardCount * 12 * 0.15m;

            decimal totalSum = bread + egg + biscuits + paintEggs;
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
