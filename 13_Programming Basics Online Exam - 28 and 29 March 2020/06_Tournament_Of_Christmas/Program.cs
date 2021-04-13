using System;

namespace _06_Tournament_Of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double moneyForTheDay = 0;
            double total = 0;
            int winCounter = 0;
            int defeatCounter = 0;

            int dayWinners = 0;
            int dayLosers = 0;

            for (int i = 0; i < days; i++)
            {
                while (true)
                {
                    string sport = Console.ReadLine();
                    if (sport == "Finish")
                    {
                        if (winCounter > defeatCounter)
                        {
                            moneyForTheDay *= 1.1;
                            total += moneyForTheDay;
                            dayWinners++;
                        }
                        else
                        {
                            total += moneyForTheDay;
                            dayLosers++;
                        }
                        moneyForTheDay = 0;
                        winCounter = 0;
                        defeatCounter = 0;
                        break;
                    }

                    string winLose = Console.ReadLine();
                    if (winLose == "win")
                    {
                        moneyForTheDay += 20;
                        winCounter++;
                    }
                    else
                    {
                        defeatCounter++;
                    }
                }
            }

            if (dayWinners > dayLosers)
            {
                Console.WriteLine($"You won the tournament! Total raised money: {total *= 1.2:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {total:f2}");
            }
        }
    }
}
