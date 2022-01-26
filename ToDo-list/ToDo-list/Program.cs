using System;
using System.IO;
using Newtonsoft.Json;
namespace ToDo_list

{
    class Program
    {
        static void Main(string[] args)
        {
            ToDo todo = new ToDo();
            todo.Title();
            int make = 0;
            int n = 0;
            do
            {
                Console.WriteLine("Введите номер дела которое вы сделали(от 1 до 5)");
                
                make = Convert.ToInt32(Console.ReadLine());
                if (make > 5 || make < 1)
                {
                    Console.WriteLine("Неверный номер");
                    break;
                } n = n + 1;
                    todo.Number(make);
               todo.IsDone(make);
            } while (1 <= make && make <= 5 && n!=5);
           string isDone = File.ReadAllText(path: "Note.txt");


            

            string text = JsonConvert.SerializeObject(isDone);
            File.WriteAllText("tasks.json", text);
            string ReadJson = File.ReadAllText(path: "tasks.json");
            Console.WriteLine(ReadJson);
           

        }

        




        }
    }
