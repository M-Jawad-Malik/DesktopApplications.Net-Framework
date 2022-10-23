using System;
using System.Diagnostics;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            ListProcesses();
        }
        private static void ListProcesses()
        {
            Process[] processCollection = Process.GetProcesses();
            foreach (Process p in processCollection)
            {
                Console.WriteLine(p.ProcessName);
            }
        }
    }
}
