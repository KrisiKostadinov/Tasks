using System;

namespace _02._Easter_Party
{
    class Program
    {
        static void Main()
        {
            int guests = int.Parse(Console.ReadLine());
            double pricePerGuest = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double cakePrice = budget * 0.10;

            if (guests >= 10 && guests <= 15)
            {
                pricePerGuest *= 0.85;
            }
            else if (guests > 15 && guests <= 20)
            {
                pricePerGuest *= 0.80;
            }
            else if (guests > 20)
            {
                pricePerGuest *= 0.75;
            }

            double nedeedTotal = guests * pricePerGuest + cakePrice;

            if (nedeedTotal <= budget)
            {
                Console.WriteLine($"It is party time! {budget - nedeedTotal:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {nedeedTotal - budget:F2} leva needed.");
            }
        }
    }
}
