using System;

namespace Massive_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] SeaBattle = new string[10, 10];
         
            for (int i = 0; i < SeaBattle.GetLength(0); i++)
            {
                for (int j = 0; j < SeaBattle.GetLength(1); j++)
                {
                    SeaBattle[i, j]="O";
                }
                
            }
            SeaBattle[2, 2] = "X";
            SeaBattle[2, 3] = "X";
            SeaBattle[1, 6] = "X"; 
            SeaBattle[5, 7] = "X"; 
            SeaBattle[5, 8] = "X";
            SeaBattle[5, 9] = "X";
            SeaBattle[1, 8] = "X";
            SeaBattle[5, 5] = "X";
            SeaBattle[6, 5] = "X";
            SeaBattle[7, 5] = "X";
            SeaBattle[8, 5] = "X";
            for (int i = 0; i < SeaBattle.GetLength(0); i++)
            {
                for (int j = 0; j < SeaBattle.GetLength(1); j++)
                {
                    Console.Write($" {SeaBattle[i, j]}");
                }
                Console.WriteLine();
            }


        }
    }
}
