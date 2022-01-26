using System;
using System.IO;
namespace tree_recurs
{
    class Program
    {
        static void Main(string[] args)
        {
            string NewDir = Directory.GetCurrentDirectory();
            KeyDir(NewDir);
        }
        public static void KeyDir(string NewDir)
        {
            string[] DirArr = Directory.GetDirectories(NewDir);
            foreach (string folder in DirArr)
            {
                Console.WriteLine("Folder " + folder);

                KeyDir(folder);
                


            }
            string[] FileDir = Directory.GetFiles(NewDir);
            foreach (string f in FileDir)
            {
                Console.WriteLine("File" + f);
            }
        }
           
        
    }
    
}
