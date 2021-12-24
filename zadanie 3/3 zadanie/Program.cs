using System;

namespace _3_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите целое число");
            int Chislo = Convert.ToInt32(Console.ReadLine());
            if (Chislo % 2 == 0) { Console.WriteLine("ваше число чётное"); }
            else
            { Console.WriteLine("ваше число нечётное"); }

        }
    }
}
