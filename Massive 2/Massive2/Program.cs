using System;

namespace Massive2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] RefBook = new string[5, 2];
            RefBook[0, 0] = "Иван Иванович       ";
            RefBook[0, 1] = "   тел. 8(999)99999999 / e-mail:ii@yandex.ru";
            RefBook[1, 0] = "Вася                ";
            RefBook[1, 1] = "  тел. 8(999)99997890 / e-mail:Vas@yandex.ru";
            RefBook[2, 0] = "Дуся                ";
            RefBook[2, 1] = "тел. 8(999)88899999 / e-mail:Dusya@yandex.ru";
            RefBook[3, 0] = "Алёна Анатольевна   ";
            RefBook[3, 1] = "   тел. 8(999)90995670 / e-mail:aa@yandex.ru";
            RefBook[4, 0] = "Сергей Сергеевич    ";
            RefBook[4, 1] = " тел. 8(909)97699999 / e-mail:Syer@yandex.ru";
            for (int i = 0; i < RefBook.GetLength(0); i++) {
                for (int j = 0; j < RefBook.GetLength(1); j++) { Console.Write(RefBook[i, j]); }
                Console.WriteLine();
            } 
        }
    }
}
