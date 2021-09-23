using System;

namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите время в минутах ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (int.TryParse(Int32, out int x))
            {
                int h = Convert.ToInt32(x / 60);
                double m = Convert.ToInt32(x % 60.0);
                Console.Write("Вам нужно завести будильник на " + h + "часов и" + m + " минут");
            }
            else
            {
                Console.Write("ОШИБКА");
            }
            Console.ReadKey();
        }
    }
}