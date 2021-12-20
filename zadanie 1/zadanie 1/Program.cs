using System;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки");
            decimal minT = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки");
            decimal maxT = Convert.ToDecimal(Console.ReadLine());

            decimal T = (minT + maxT) / 2;
            Console.WriteLine($"Средняя температура за сутки:{T}");
        }
    }
}
