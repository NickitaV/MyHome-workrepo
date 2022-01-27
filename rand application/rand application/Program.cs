using System;

namespace rand_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Input(out double One, out double Two);
            
            Calc(One, Two);




        }

        static void Input(out double OneValue, out double TwoValue) {
            Console.WriteLine("Введите первое число");
            OneValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            TwoValue = Convert.ToDouble(Console.ReadLine());

        }
        static void Calc(double One, double Two) {
            Console.WriteLine("a-сумма\nb-разность\nc-произведение\nd- частное\n");
            double result;
            string Val = Console.ReadLine();
            switch (Val) {
                case "a": result = One + Two; Console.WriteLine("Cумма чисел: " + result);break;
                case "b": result = One - Two; Console.WriteLine("Разность чисел: " + result); break;
                case "c": result = One * Two; Console.WriteLine("Произведение чисел: " + result); break;
                case "d": if (Two == 0) { Console.WriteLine("Делить на ноль нельзя"); break; }
                    else { result = One / Two; Console.WriteLine("Частное чисел: " + result);break; }
                case "ф": result = One + Two; Console.WriteLine("Cумма чисел: " + result); break;
                case "и": result = One - Two; Console.WriteLine("Разность чисел: " + result); break;
                case "с": result = One * Two; Console.WriteLine("Произведение чисел: " + result); break;
                case "в":
                    if (Two == 0) { Console.WriteLine("Делить на ноль нельзя"); break; }
                    else { result = One / Two; Console.WriteLine("Частное чисел: " + result); break; }


            }

        }
    
    
    
    }
}
