using System;

namespace Massive_1_vers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива: ");
            
            int v = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine($"Введите {v} символов через ENTER");
            string [] f = new string[v];
            
            
            int n = 0; 
            do
            {
                
                f[n] = Console.ReadLine();
                n += 1;
            } while (n < v);
           
            string[,] array = new string[v, v];
            int i = 0; int j = 0;
            for (int k = 0; k < f.Length; k++)
            {
                if ((i==j)&&(i < array.GetLength(0)) && (j < array.GetLength(1)))
                {
                    
                    array[i, j] = $"{f[k]}";
                    i += 1; j += 1;
                }
               
               
            }

                for (int i1 = 0; i1 < array.GetLength(0); i1++)
                {
                    for (int j1 = 0; j1 < array.GetLength(1); j1++)
                    {
                        Console.Write($" {array[i1, j1]}");
                    }
                    Console.WriteLine();
                
            }
        }
    }
}
