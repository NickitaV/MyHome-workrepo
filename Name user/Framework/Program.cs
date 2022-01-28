using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("version 1.0 This Programm remembers info about user");
            Console.WriteLine(Properties.Settings.Default.Hello);
            string Y; 
            
                if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
                {

                    Input(out string Name, out string Age, out string Business);

                    Prop(Name, Age, Business);
                }
                UserProp();
                Console.WriteLine("Если хотите поменять имя пользователя, нажмите y");
                Y = Console.ReadLine();
            if ((Y == "y") || (Y == "н")) { 
                Input(out string Name, out string Age, out string Business); 
                Prop(Name, Age, Business); 
                UserProp();
            } Console.ReadKey();
        }
        static void Input(out string Name, out string Age, out string Business) {
            Console.WriteLine("Введите имя пользователя:");
            Name = Console.ReadLine();

            Console.WriteLine("Введите возраст пользователя:");
            Age = Console.ReadLine();
            Console.WriteLine("Введите род деятельности пользователя:");
            Business = Console.ReadLine();
        }

        static void Prop(string Name, string Age, string Business)
        {



            Properties.Settings.Default.UserName = Name;
            Properties.Settings.Default.Save();

            Properties.Settings.Default.UserAge = Age;
            Properties.Settings.Default.Save();

            Properties.Settings.Default.UserBusiness = Business;
            Properties.Settings.Default.Save();
        }



            static void UserProp(){
                Console.WriteLine(Properties.Settings.Default.UserName);
                Console.WriteLine(Properties.Settings.Default.UserAge);
                Console.WriteLine(Properties.Settings.Default.UserBusiness);

                
        }
  

    }
}
