using System;

namespace _02_Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distanceInM = double.Parse(Console.ReadLine());
            double timeSInM = double.Parse(Console.ReadLine());

            double totalDistSM = distanceInM * timeSInM;
            double delay = Math.Floor(distanceInM / 50);
            double totalDelay = delay * 30;
            double totalTime = (totalDistSM + totalDelay);
            if (totalTime < record)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                double neededTime = totalTime - record;
                Console.WriteLine($"No! He was {neededTime:f2} seconds slower.");
            }
        }
    }
}
