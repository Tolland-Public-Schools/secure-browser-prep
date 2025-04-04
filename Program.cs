using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace SecureBrowserPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Closing apps that prevent the Secure Browsering from running");
            List<Process> allProcess = new List<Process>(Process.GetProcesses());
            List<Process> toKill =  new List<Process>();

            allProcess
                .Where(x => x.ProcessName.ToLower()
                    .StartsWith("teams"))
                .ToList()
                .ForEach(x => toKill.Add(x));
            allProcess
                .Where(x => x.ProcessName.ToLower()
                    .StartsWith("teamviewer"))
                .ToList()
                .ForEach(x => toKill.Add(x));
            allProcess
                .Where(x => x.ProcessName.ToLower()
                    .StartsWith("smart"))
                .ToList()
                .ForEach(x => toKill.Add(x));
            allProcess
                .Where(x => x.ProcessName.ToLower()
                    .StartsWith("notebook"))
                .ToList()
                .ForEach(x => toKill.Add(x));
            allProcess
                .Where(x => x.ProcessName.ToLower()
                    .StartsWith("chrome"))
                .ToList()
                .ForEach(x => toKill.Add(x));
            allProcess
                .Where(x => x.ProcessName.ToLower()
                    .StartsWith("firefox"))
                .ToList()
                .ForEach(x => toKill.Add(x));
            allProcess
                .Where(x => x.ProcessName.ToLower()
                    .StartsWith("ms-teams"))
                .ToList()
                .ForEach(x => toKill.Add(x));
            allProcess
                .Where(x => x.ProcessName.ToLower()
                    .StartsWith("snippingtool"))
                .ToList()
                .ForEach(x => toKill.Add(x));
            allProcess
                .Where(x => x.ProcessName.ToLower()
                    .StartsWith("taskmgr"))
                .ToList()
                .ForEach(x => toKill.Add(x));

            foreach (Process p in toKill)
            {
                try
                {
                    Console.WriteLine("Closing {0}", p.ProcessName);
                    p.Kill();
                }
                catch (Exception e)
                {

                }
            }

            // foreach (var process in Process.GetProcessesByName("Teams"))
            // {
            //     process.Kill();
            // }
            Console.WriteLine("All done");
        }
    }
}