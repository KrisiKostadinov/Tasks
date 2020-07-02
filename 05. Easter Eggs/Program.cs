using System;

namespace _05._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsCount = int.Parse(Console.ReadLine());

            int orangeCount = 0;
            int blueCount = 0;
            int greenCount = 0;
            int redCount = 0;

            int maxNumber = 0;
            int prevMaxNumber = 1;
            string eggColor = "";

            for (int i = 0; i < eggsCount; i++)
            {
                string command = Console.ReadLine().Trim();

                switch (command)
                {
                    case "orange":
                        orangeCount++;
                        if (orangeCount > maxNumber)
                        {
                            eggColor = command;
                            maxNumber = orangeCount;
                        }
                        break;
                    case "blue":
                        blueCount++;
                        if (blueCount > maxNumber)
                        {
                            eggColor = command;
                            maxNumber = blueCount;
                        }
                        break;
                    case "green":
                        greenCount++;
                        if (greenCount > maxNumber)
                        {
                            eggColor = command;
                            maxNumber = greenCount;
                        }
                        break;
                    case "red":
                        redCount++;
                        if (redCount > maxNumber)
                        {
                            eggColor = command;
                            maxNumber = redCount;
                        }
                        break;
                }
            }

            Console.WriteLine($"Red eggs: {redCount}");
            Console.WriteLine($"Orange eggs: {orangeCount}");
            Console.WriteLine($"Blue eggs: {blueCount}");
            Console.WriteLine($"Green eggs: {greenCount}");

            Console.WriteLine($"Max eggs: {maxNumber} -> {eggColor}");
        }
    }
}
