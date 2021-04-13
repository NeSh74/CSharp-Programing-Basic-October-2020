using System;

namespace _04_Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGroups = int.Parse(Console.ReadLine());
            int musala = 0;
            int monblan = 0;
            int kilimandgaro = 0;
            int k2 = 0;
            int everest = 0;

            for (int i = 0; i < numGroups; i++)
            {
                int people = int.Parse(Console.ReadLine());
                if (people <= 5)
                {
                    musala += people;
                }
                else if (people >= 6 && people <= 12)
                {
                    monblan += people;
                }
                else if (people >= 13 && people <= 25)
                {
                    kilimandgaro += people;
                }
                else if (people >= 26 & people <= 40)
                {
                    k2 += people;
                }
                else if (people >= 41)
                {
                    everest += people;
                }
            }
            int allPeople = musala + monblan + kilimandgaro + k2 + everest;
            Console.WriteLine($"{musala * 100.0 / allPeople:f2}%");
            Console.WriteLine($"{monblan * 100.0 / allPeople:f2}%");
            Console.WriteLine($"{kilimandgaro * 100.0 / allPeople:f2}%");
            Console.WriteLine($"{k2 * 100.0 / allPeople:f2}%");
            Console.WriteLine($"{everest * 100.0 / allPeople:f2}%");
        }
    }
}
