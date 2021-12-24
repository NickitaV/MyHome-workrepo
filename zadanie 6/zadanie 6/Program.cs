using System;

namespace zadanie_6
{
    class Program
    {
        [Flags]
        public enum Week
        {
            Пн = 0b_0000001,
            Вт = 0b_0000010,
            Ср = 0b_0000100,
            Чт = 0b_0001000,
            Пт = 0b_0010000,
            Сб = 0b_0100000,
            Вс = 0b_1000000,
        }
        static void Main(string[] args)
        {
            
            Week workOffice1 = (Week)0b0000111;
            Week workOffice2 = (Week)0b1010101;
            Week workOffice3 = (Week)0b0011111;
            Console.WriteLine($"|Название офиса:|   |Дни работы:|");
            Console.WriteLine($"     Офис 1:         {workOffice1}");
            Console.WriteLine($"     Офис 2:         {workOffice2}");
            Console.WriteLine($"     Офис 3:         {workOffice3}");
          
        }
    }
}