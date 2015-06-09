using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.CompilerServices;

namespace L6M1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DelegateMethode myDelegate = new DelegateMethode(CalculateSquareRoot);

            if (myDelegate != null)
            {
                double value = myDelegate.Invoke(4.5);
                Console.WriteLine("Square Root: " + value);
            }

            myDelegate -= CalculateSquareRoot;
            myDelegate += CalculateSin;

            if (myDelegate != null)
            {
                IAsyncResult result = myDelegate.BeginInvoke(5, null, null);
                result.AsyncWaitHandle.WaitOne();
                double sinusResult = myDelegate.EndInvoke(result);
                Console.WriteLine("Sinus Result: "+ sinusResult);

                Console.ReadLine();
            }

        }

        public static double CalculateSquareRoot(double squareRoot)
        {
            return System.Math.Sqrt(squareRoot);
            
        }

        public static double CalculateSin(double sinus)
        {
            return System.Math.Sin(sinus);

        }

        public delegate double DelegateMethode(double input);

    }
}
