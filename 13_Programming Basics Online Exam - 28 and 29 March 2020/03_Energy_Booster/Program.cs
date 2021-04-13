using System;

namespace _03_Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string setType = Console.ReadLine();
            int orderSet = int.Parse(Console.ReadLine());

            double fruitPrice = 0;
            double setNum = 0;


            if (fruit == "Watermelon")
            {
                if (setType == "small")
                {
                    setNum = 2;
                    fruitPrice = 56.00;
                }
                else if (setType == "big")
                {
                    setNum = 5;
                    fruitPrice = 28.70;
                }
            }
            else if (fruit == "Mango")
            {
                if (setType == "small")
                {
                    setNum = 2;
                    fruitPrice = 36.66;
                }
                else if (setType == "big")
                {
                    setNum = 5;
                    fruitPrice = 19.60;
                }
            }
            if (fruit == "Pineapple")
            {
                if (setType == "small")
                {
                    setNum = 2;
                    fruitPrice = 42.10;
                }
                else if (setType == "big")
                {
                    setNum = 5;
                    fruitPrice = 24.80;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (setType == "small")
                {
                    setNum = 2;
                    fruitPrice = 20.00;
                }
                else if (setType == "big")
                {
                    setNum = 5;
                    fruitPrice = 15.20;
                }
            }
            double result = setNum * fruitPrice * orderSet;
            if (result >= 400 && result <= 1000)
            {
                result *= 0.85;
            }
            else if (result > 1000)
            {
                result *= 0.50;
            }
            Console.WriteLine("{0:f2} lv.", result);
        }
    }
}
