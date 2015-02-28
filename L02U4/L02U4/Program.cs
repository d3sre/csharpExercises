using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02U4
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            int[] intArray = new int[1000];
            Random rnd = new Random();
            string outputString = "";

            for (int i = 0; i < 1000; i++)
            {
                do
                {
                    value = rnd.Next(0, 1001);
                }
                while (intArray.Contains(value));

                intArray[i] = value;

               if (i != 999) 
               { 
                    outputString = outputString + intArray[i].ToString() + ",";
               }
               else
               {
                    outputString = outputString + intArray[i].ToString();

               }
            }
            Console.WriteLine(outputString);
            Console.ReadLine();
        }
    }
}

