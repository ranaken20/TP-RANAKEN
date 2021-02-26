using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.Text;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformanceCounter cpuFrequency;
            cpuFrequency = new PerformanceCounter();
            cpuFrequency.CategoryName = "Processor Information";
            cpuFrequency.CounterName = "Processor Frequency";
            cpuFrequency.InstanceName = "0,0";


            cpuFrequency.RawValue = 0;
            cpuFrequency.ReadOnly = false;
            Console.Write("Frequency of processor 0 is: ");
            DateTime tempsdebut = DateTime.Now; 
            int i, c = 0;
            for (i = 0; i < 1000000000; i++)
                c++;
            DateTime tempsarret = DateTime.Now;
            TimeSpan duration = tempsarret - tempsdebut;
            Console.WriteLine(duration);
            Process currentProcess = Process.GetCurrentProcess();
            string pid = currentProcess.Id.ToString();
            Console.WriteLine("PID: " + pid);
            string utilisateur = Environment.UserName;
            Console.WriteLine(utilisateur);
            Process Process1 = Process.Start("notepad.exe");
            Thread.Sleep(5000);
            Process1.Close();
        }
    }
}
