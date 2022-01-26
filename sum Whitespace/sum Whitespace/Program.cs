using System;

namespace sum_Whitespace
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Input();
            int[] a = TransformInput(input);
            int sum = Sum(a);
            Console.WriteLine(sum);
        }
        static string Input()
        {
            Console.WriteLine("Введите несколько чисел через пробел");
            string input = Console.ReadLine();
            return input;
        }
        static int[] TransformInput(string input)
        {
            input = input.Replace(" ", string.Empty);



            int[] a = new int[input.Length];
            for (int i = 0; i < input.Length; i++) { a[i] = Convert.ToInt32(input[i].ToString()); }
            return a;
        }


        static int Sum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++) { sum += a[i]; }
            return sum;
        }












    }
}
