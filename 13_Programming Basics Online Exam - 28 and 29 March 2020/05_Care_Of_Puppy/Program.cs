using System;

namespace _05_Care_Of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            food *= 1000;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Adopted")
                {
                    if (food < 0)
                    {
                        Console.WriteLine($"Food is not enough. You need {Math.Abs(food)} grams more.");
                    }
                    else
                    {
                        Console.WriteLine($"Food is enough! Leftovers: {food} grams.");
                    }
                    break;
                }
                int eatenFood = int.Parse(input);

                food -= eatenFood;
            }
        }
    }
}
