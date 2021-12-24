using System;

namespace Massive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 8, 2, 3 }, { 4, 5, 9 } };
           int[] array1 = new int[6];
            int n = -1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    n ++;
                    array1[n] = array[i, j];

                }
              
                }

            int sdvig = 0;
            foreach (int f in array1)
            {
                Console.WriteLine(f.ToString().PadLeft(sdvig += 1));
            }
        }
    }
}
