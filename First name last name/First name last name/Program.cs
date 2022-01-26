using System;

namespace First_name_last_name
{
    class Program
    {
        static void Main(string[] args)
        {
           string sum = Sum();
            bool correct = ChekSum(sum);
            if (correct == true)
            {
                int sumNew = TransformSum(sum);
                string userNew = GetFullName();
                SomeName(userNew, sumNew);


            }
            else Warning();

            
        }
       static string Sum() {
            Console.WriteLine("Введите число фамилий в списке");
            string sum = Console.ReadLine();
            return sum;
        }

        static bool ChekSum(string sum) {
            if (string.IsNullOrWhiteSpace(sum))
            {
                return false;
            }

                if (Convert.ToInt32(sum) < 1) { return false; }
          
            return true; }
        static void Warning() { Console.WriteLine("Введите число фамилий не менее 1"); }

        static int TransformSum(string sum)
            {
                int sumNew = Convert.ToInt32(sum);
          
            return sumNew;
        }


        static string GetFullName()
        {

            Console.WriteLine("Введите имя");
           string firstName = Console.ReadLine();


            Console.WriteLine("Введите отчество");
            string patronymic = Console.ReadLine(); 
            
            Console.WriteLine("Введите фамилию");
            string lastName = Console.ReadLine();

           
        
            string userNew = firstName + " " + patronymic + " " + lastName;
            return userNew;
        }
       
        static void SomeName(string userNew, int sumNew) {
            string[] a = new string[sumNew];
             a[0] = userNew;
            
                for (int n = 2; n <= a.Length; n++)
                {
                    userNew = GetFullName();

                    a[n-1] = userNew;

                }


            for (int i = 0; i < a.Length; i++) { Console.WriteLine($"{i + 1}. { a[i]}"); }
        }
       
    
      
    }
}
