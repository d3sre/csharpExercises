using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace L02U2
{
    public static class Program
    {
        /// <summary>
        /// Entry of app
        /// Inspiration from https://msdn.microsoft.com/en-us/library/79b3xss3.aspx
        /// </summary>
        /// <param name="args">No Input taken from beginning</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Please select your convertion");
            Console.WriteLine("1. From cm to inch");
            Console.WriteLine("2. From inch to cm");

            string choice = Console.ReadLine();
            double length = 0;

            switch (choice)
            {
                case "1":
                    Console.Write("How many cm? ");
                    length = Program.cm2inch(Console.ReadLine());
                    Console.WriteLine("this is {0} inch", length);
                    break;

                case "2":
                    Console.Write("How many inch? ");
                    length = Program.inch2cm(Console.ReadLine());
                    Console.WriteLine("this is {0} cm", length);
                    break;

                default:
                    Console.WriteLine("Please select your convertion: ");
                    break;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static double cm2inch(string cmString) {
            double cm = Double.Parse(cmString);
            return cm * 0.393701;
        }

        public static double inch2cm(string inchString)
        {
            double inch = Double.Parse(inchString);
            return inch * 2.54;
        }

    }
}
