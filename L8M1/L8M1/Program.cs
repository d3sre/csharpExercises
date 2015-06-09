    using System;
using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8M1
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentProcess =  Process.GetCurrentProcess();

            string pname = currentProcess.ProcessName;
            Console.WriteLine("Process Name: {0}", pname);
            string pid = currentProcess.Id.ToString();
            Console.WriteLine("Process ID: {0}", pid);
            string pthreads = currentProcess.Threads.ToString();
            Console.WriteLine("Threads: {0}", pthreads);
            string pstarttime = currentProcess.StartTime.ToString();
            Console.WriteLine("Start Time: {0}", pstarttime);

            ProcessModuleCollection modules = currentProcess.Modules;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ModuleName: {0}", modules[i].ModuleName);
            }

            Console.WriteLine("Module Count: {0}", modules.Count);

            Console.ReadLine();

        }
    }
}
