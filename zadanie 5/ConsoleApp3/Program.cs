using System;

namespace ConsoleApp3
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

            Console.WriteLine("Введите номер месяца от 1 до 12");
            int NumberofMonth = Convert.ToInt32(Console.ReadLine());

            string MonthTitle = "";
            switch (NumberofMonth)
            {
                case 1: MonthTitle = "январь"; break;
                case 2: MonthTitle = "февраль"; break;
                case 3: MonthTitle = "март"; break;
                case 4: MonthTitle = "апрель"; break;
                case 5: MonthTitle = "май"; break;
                case 6: MonthTitle = "июнь"; break;
                case 7: MonthTitle = "июль"; break;
                case 8: MonthTitle = "август"; break;
                case 9: MonthTitle = "сентябрь"; break;
                case 10: MonthTitle = "октябрь"; break;
                case 11: MonthTitle = "ноябрь"; break;
                case 12: MonthTitle = "декабрь"; break;
            }
            Console.WriteLine(MonthTitle);
            if ((NumberofMonth == 1 || NumberofMonth == 2 || NumberofMonth == 12) && (T > 0))
            {
                Console.WriteLine("Дождливая зима");
            }
            


        }
    }
}
