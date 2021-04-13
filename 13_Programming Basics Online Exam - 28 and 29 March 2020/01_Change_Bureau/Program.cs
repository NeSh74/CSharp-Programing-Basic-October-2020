using System;

namespace _01_Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double china = double.Parse(Console.ReadLine());
            double commition = double.Parse(Console.ReadLine());
            double bitcoinInBGN = bitcoin * 1168;
            double chinaInUSD = china * 0.15;
            double USDInBGN = chinaInUSD * 1.76;

            double euro = (bitcoinInBGN + USDInBGN) / 1.95;
            double commitionInEur = (euro * commition) / 100;
            double receivedAmount = euro - commitionInEur;
            Console.WriteLine($"{receivedAmount:f2}");
        }
    }
}
