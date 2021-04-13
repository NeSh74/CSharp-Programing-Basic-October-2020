using System;

namespace _02_Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int numWalks = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());
            int totalTimeWalk = minutes * numWalks;

            int burnedCalories = 5 * totalTimeWalk;

            double totalBurnedCalories = calories * 0.50;

            if (burnedCalories >= totalBurnedCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
            }
            else
            {
                Console.Write($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");
            }
        }
    }
}
