using System;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = Input();


            Result(input);



        }


        static int Input()
        {
            Console.WriteLine("Введите целое число:");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }






        static int Fib(int n)
        {
            if (n == 0) { return 0; }
            if (n == 1) { return 1; }
            else
                return Fib(n - 1) + Fib(n - 2);

        }
        static void Result(int input) { for (int i = 0; i < input; i++) { Console.WriteLine(Fib(i)); } }


    }
}