using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace Task_M
{
    public class Task
    {
        public void Title()
        {
            Console.WriteLine("название процесса");
            Console.WriteLine("=================");

        }
        public void Proc(Process[] proc)
        {


            for (int i = 0; i < proc.Length; i++)
            {
                Process process = proc[i];

                Console.WriteLine(process.ProcessName);


            }

        }
        public void FinalProc(Process[] proc)
        {
            Console.WriteLine("Введите название процесса, который вы хотели бы завершить");
            string p = Console.ReadLine();

            for (int i = 0; i < proc.Length; i++)
            {
                if (proc[i].ProcessName == p)
                {
                    proc[i].Kill();

                     
                    Task_remember.Properties.Settings.Default.Process = proc[i].ProcessName;
                    Task_remember.Properties.Settings.Default.Save();
                    
                }

            }
        }
    }
}


