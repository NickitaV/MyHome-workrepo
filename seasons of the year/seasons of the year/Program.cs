using System;

namespace seasons_of_the_year
{
    class Program
    {
        public enum Season{ Winter, Spring, Summer, Autumn }
        static void Main(string[] args)
        {
            Season season = new Season();
            
           string input = Input();
           bool correct= Chek(input);
            if (correct == true)
            {
                int inputInt = Transform(input);
                WhatSeason(inputInt, season);
            }
           else Warning();
        }
        

        static string Input() {
            Console.WriteLine("Введите номер месяца:");
            string input = Console.ReadLine();
            return input;
        }

        static bool Chek(string input) {
            int i = Convert.ToInt32(input);
            if (string.IsNullOrWhiteSpace(input) || i<1||i>12)
            {
                return false;
            }
            return true;
        }
        static int Transform(string input) { int inputInt = Convert.ToInt32(input);
            return inputInt;
        }

        static void Warning() { Console.WriteLine("Введите целое число от 1 до 12"); }
        static void WhatSeason(int inputInt, Season season) {
            
            switch(inputInt)
            {
                case 1: season = (Season)0; break;
                case 2: season = (Season)0; break;
                case 3: season = (Season)1; break;
                case 4: season = (Season)1; break;
                case 5: season = (Season)1; break;
                case 6: season = (Season)2; break;
                case 7: season = (Season)2; break;
                case 8: season = (Season)2; break; 
                case 9: season = (Season)3; break;
                case 10: season = (Season)3; break;
                case 11: season = (Season)3; break;
                case 12: season = (Season)0; break;
            }
            string SeasonTitle = "";
            switch(season){

                case (Season)0:SeasonTitle = "Зима"; break;
                case (Season)1: SeasonTitle = "Весна"; break;
                case (Season)2: SeasonTitle = "Лето"; break;
                case (Season)3: SeasonTitle = "Осень"; break;




            }
            
            Console.WriteLine(SeasonTitle);
        
        }




    }
}
