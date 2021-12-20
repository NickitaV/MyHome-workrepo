using System;

namespace zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Shop = "New shop";
            DateTime dt = DateTime.Now;
            int Number = 1;
            string Text1 = "Вода минеральная";
            string Text2 = "Батончик Сникерс";
            string Text3 = "Хлеб нарезной";
            string Text4 = "Фиш ролл";
            string Text5 = "Цемент";
           float Price1 = 43.80f;
            float Price2 = 39.00f;
            float Price3 = 29.00f;
            float Price4 = 160.50f;
            float Price5 = 5400.50f;

           Console.WriteLine($"       OOO {Shop}");
            Console.WriteLine($"Время: {dt}");
            Console.WriteLine($" -----Список покупок-----"); 
            Console.WriteLine($"|------------------------|"); 
            Console.WriteLine($"{Number}. {Text1}\n.....................{Price1}");
            Console.WriteLine($"|------------------------|");
            Console.WriteLine($"{Number += 1}. {Text2}\n.....................{Price2}");
            Console.WriteLine($"|------------------------|"); 
            Console.WriteLine($"{Number += 1}. {Text3}\n.....................{Price3}");
            Console.WriteLine($"|------------------------|"); 
            Console.WriteLine($"{Number += 1}. {Text4}\n.....................{Price4}");
            Console.WriteLine($"|------------------------|"); 
            Console.WriteLine($"{Number += 1}. {Text5}\n....................{Price5}"); 
            Console.WriteLine($"|------------------------|");
            Console.WriteLine($"ИТОГО:             {Price1+ Price2+ Price3 + Price4 + Price5}");
        }
    }
}
