using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace L8U1
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteFile();
            System.Threading.Thread.Sleep(5000);
            PrintFile();

            Console.ReadLine();
        }

        static void WriteFile()
        {
            string dataInput = "beliebiger text";

            bool exists = File.Exists(@"L8U1test.txt");
            if (exists)
            {
                File.Delete(@"L8U1test.txt");
            }

            File.WriteAllText(@"L8U1test.txt", dataInput);
        

        }

        static void PrintFile()
        {
            string contentFile = File.ReadAllText(@"L8U1test.txt");
            Console.WriteLine(contentFile);
        }
    }
}
