

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
namespace Task_M
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"В прошлый раз вы завершили: {Task_remember.Properties.Settings.Default.Process}");
                Task task = new Task();
                task.Title();
                Process[] proc = Process.GetProcesses();
                task.Proc(proc);
                task.FinalProc(proc);


                Console.WriteLine($"имя завершённого процесса: {Task_remember.Properties.Settings.Default.Process}");
                Console.ReadKey();
            }
            catch (Exception) { Console.WriteLine("Error"); }
        }
    }
}
