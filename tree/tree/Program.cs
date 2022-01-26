using System;
using System.IO;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            File.Delete(path: "note.txt");
            tree.Dir();
            string ReadNewText = File.ReadAllText(path: "note.txt");
            Console.WriteLine($"Текст из файла: {ReadNewText}");

        }
    }
}
