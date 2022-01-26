using System;
using System.Collections.Generic;
using System.Text;

using System.Diagnostics;

    namespace Task_M
{
    public class Task 
    {
        public void Title() {
            Console.WriteLine("название процесса (ID процесса)");
            Console.WriteLine("===============================");
            
        }
        public void Proc(Process[] proc) {
            
            
                for (int i = 0; i < proc.Length; i++)
                {
                    Process process = proc[i];
                    
                    Console.WriteLine(process.ProcessName+"(ID: "+ process.Id+")");
                   

                }
            
        }
        public void FinalProc(Process[] proc) {
            Console.WriteLine("Введите название процесса, который вы хотели бы завершить или ID процесса:");
            string p = Console.ReadLine();

            for (int i = 0; i < proc.Length; i++)
            {
                if ((proc[i].ProcessName == p)||(proc[i].Id == Convert.ToInt32(p)))
                {
                    proc[i].Kill();
                    Console.WriteLine("Работа процесса: " + proc[i] + " завершёна");
                }

            }
        }
    }
}
