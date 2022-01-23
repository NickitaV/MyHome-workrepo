using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace binarniy_file
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Введите любые целые числа от 0 до 255");
            string New = Console.ReadLine();
            byte[] a = new byte[New.Length];
            NewMethod(New, a);
            File.WriteAllBytes("bytes.bin", a);
            byte[] fromFile = File.ReadAllBytes("bytes.bin");
            FromFile(fromFile);
        }

        private static void NewMethod(string New, byte[] a)
        {
            for (int i = 0; i < New.Length; i++) { a[i] = Convert.ToByte(New[i].ToString()); }
        }
        private static void FromFile(byte[] fromFile) {for (int i = 0; i< fromFile.Length; i++) { Console.WriteLine(fromFile[i]); } }
}
}
