using System;

namespace _04_Food_For_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());
            double quantityFood = double.Parse(Console.ReadLine());

            double eatenDogFood = 0;
            double eatenCatFood = 0;
            double biscuits = 0;

            for (int i = 1; i <= numDays; i++)
            {
                double foodDog = int.Parse(Console.ReadLine());
                double foodCat = int.Parse(Console.ReadLine());

                eatenDogFood += foodDog;
                eatenCatFood += foodCat;

                if (i % 3 == 0)
                {
                    biscuits += (foodDog + foodCat) * 0.1;
                }
            }
            double eatenFood = (eatenDogFood + eatenCatFood) / quantityFood * 100;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{eatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{eatenDogFood / (eatenCatFood + eatenDogFood) * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{eatenCatFood / (eatenCatFood + eatenDogFood) * 100:f2}% eaten from the cat.");
        }
    }
}
