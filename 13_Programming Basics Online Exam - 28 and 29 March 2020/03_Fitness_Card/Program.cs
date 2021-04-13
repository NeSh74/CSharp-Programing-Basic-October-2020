using System;

namespace _03_Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double cardPice = 0;

            switch (sport)
            {
                case "Gym":
                    if (gender == "m")
                    {
                        cardPice = 42;
                    }
                    else if (gender == "f")
                    {
                        cardPice = 35;
                    }
                    break;
                case "Boxing":
                    if (gender == "m")
                    {
                        cardPice = 41;
                    }
                    else if (gender == "f")
                    {
                        cardPice = 37;
                    }
                    break;
                case "Yoga":
                    if (gender == "m")
                    {
                        cardPice = 45;
                    }
                    else if (gender == "f")
                    {
                        cardPice = 42;
                    }
                    break;
                case "Zumba":
                    if (gender == "m")
                    {
                        cardPice = 34;
                    }
                    else if (gender == "f")
                    {
                        cardPice = 31;
                    }
                    break;
                case "Dances":
                    if (gender == "m")
                    {
                        cardPice = 51;
                    }
                    else if (gender == "f")
                    {
                        cardPice = 53;
                    }
                    break;
                case "Pilates":
                    if (gender == "m")
                    {
                        cardPice = 39;
                    }
                    else if (gender == "f")
                    {
                        cardPice = 37;
                    }
                    break;
            }

            if (age <= 19)
            {
                cardPice *= 0.80;
            }

            if (cash >= cardPice)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${cardPice - cash:f2} more.");
            }
        }
    }
}
