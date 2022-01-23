using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace ToDo_list
{
    class ToDo
    {

       
       
         
        public void Title() { string[] str = new string[5];
        int i;
            do
            {
                for (i = 0; i<str.Length; i++)
                {
                    Console.WriteLine("Введите текстом дело в список дел");

                    str[i] = Console.ReadLine();

                }
} while (i < 5) ;


File.WriteAllLines(path: "Note.txt", contents: str);
string Read = File.ReadAllText(path: "Note.txt");
Console.WriteLine(Read);}
        
       
        public void Number(int make) { string[]text = File.ReadAllLines(path: "Note.txt");
            
                string m = Convert.ToString(make);
                string s = text[make - 1];
                char[] S = s.ToCharArray();
                char[] M = m.ToCharArray();
                
                if (S[0] == M[0]) { Console.WriteLine("Такой номер уже был"); }
                else
                {

                    text[make - 1] = make + ". " + text[make - 1];
                    File.WriteAllLines(path: "Note.txt", contents: text);


                }
            
        }




        public void IsDone(int make)
        {

            string[] text = File.ReadAllLines(path: "Note.txt");
            

                text[make - 1] = text[make - 1] + "       [X]";
                File.WriteAllLines(path: "Note.txt", contents: text);
                string Read = File.ReadAllText(path: "Note.txt");
                Console.WriteLine(Read); }
            
        


   







    } }
