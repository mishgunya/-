using System;
using System.Numerics;

namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите время, в которое собираетесь лечь спать (сначала часы, затем минуты) ");
            int h1 = Convert.ToInt32(Console.ReadLine());
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите время необходимое для сна (в минутах) ");
            int x = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(x / 60);
            double m = Convert.ToInt32(x % 60.0);
            int h2 = Convert.ToInt32(h1 + h);
            int m2 = Convert.ToInt32(m1 + m);
            if (m2 > 60)
            {
                int h3 = h2 + 1;
                int m3 = m2 % 60;
                Console.Write("Вам нужно завести будильник на " + h3 + "часов и " + m3 + " минут");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Вам нужно завести будильник на " + h2 + "часов и" + m2 + " минут");
                Console.ReadKey();
            }
            
        }
    }
}