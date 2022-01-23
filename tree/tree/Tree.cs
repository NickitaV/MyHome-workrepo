using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace tree
{
    class Tree

    {

        public void Dir()
        {
           
            {

                string currentDirectory = Directory.GetCurrentDirectory();
                foreach (string file in Directory.EnumerateFiles(currentDirectory))
                {
                    Console.WriteLine(file); File.AppendAllText(path: "note.txt", contents: file);


                }



            }
        }
    }
}

