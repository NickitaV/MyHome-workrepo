using System;
using System.IO;
namespace start_date
{
    class Program
    {
       

        static void Main(string[] args)
        {
            File.WriteAllText(path: "TimeDate.txt",
                              contents:DateTime.Now.ToString());

            if (File.Exists(path: "TimeDate.txt")) { Console.WriteLine("Файл создан"); }
            string ReadNewText = File.ReadAllText(path: "TimeDate.txt");
            Console.WriteLine(ReadNewText);

        }
    }
}
