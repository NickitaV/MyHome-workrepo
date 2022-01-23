using System;
using System.IO;
namespace text_file
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string newText = Console.ReadLine();
            File.WriteAllText(path:"NewText.txt", contents:newText);
            if (File.Exists(path: "NewText.txt")){ Console.WriteLine("Файл создан"); }
            string ReadNewText = File.ReadAllText(path: "NewText.txt");
            Console.WriteLine(ReadNewText);


        }
    }
}
