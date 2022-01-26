using System;

using System.Diagnostics;
namespace Task_M
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
             
            Task task = new Task();
            task.Title();
            Process[] proc = Process.GetProcesses();
            task.Proc(proc);
            task.FinalProc(proc);
            }
            catch (Exception) { Console.WriteLine("Error"); }
        }
    }
}
