using System;

namespace _01.Supplies_For_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPens = int.Parse(Console.ReadLine());
            int numMarkers = int.Parse(Console.ReadLine());
            double cleaning = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pensPrice = 5.80;
            double markersPrice = 7.20;
            double cleaningPrice = 1.20;
            double amount = numPens * pensPrice + numMarkers * markersPrice + cleaning * cleaningPrice;
            double finalAmount = (amount - (amount * discount) / 100);

            Console.WriteLine($"{finalAmount:f3}");
        }
    }
}
