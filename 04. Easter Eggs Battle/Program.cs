using System;

namespace _04._Easter_Eggs_Battle
{
    class Program
    {
        static void Main()
        {
            int eggsCountFirstPlayer = int.Parse(Console.ReadLine());
            int eggsCountSecondPlayer = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "End of battle")
            {
                if (command == "one")
                {
                    eggsCountSecondPlayer--;
                }
                else if (command == "two")
                {
                    eggsCountFirstPlayer--;
                }
                if (eggsCountFirstPlayer == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {eggsCountSecondPlayer} eggs left.");
                    return;
                }
                if (eggsCountSecondPlayer == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {eggsCountFirstPlayer} eggs left.");
                    return;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Player one has {eggsCountFirstPlayer} eggs left.");
            Console.WriteLine($"Player two has {eggsCountSecondPlayer} eggs left.");
        }
    }
}
