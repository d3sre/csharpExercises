using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calcClient = new ServiceReference1.CalculatorClient();
                var myParameter = new ServiceReference1.MyCalculator { param1 = 5, param2 = 4 };

                var add = calcClient.Addition(myParameter);
                Console.WriteLine("{0} = {1}", "Addition: ", add);

                var sub = calcClient.Subtraction(myParameter);
                Console.WriteLine("{0} = {1}", "Subtraction: ", sub);

                var multi = calcClient.Multiply(myParameter);
                Console.WriteLine("{0} = {1}", "Multiply: ", multi);

                var div = calcClient.Divide(myParameter);
                Console.WriteLine("{0} = {1}", "Division: ", div);


            }
            catch (Exception e)
            {
                Console.WriteLine("Error has happened with Calculator Service Test\n: {0}", e);

                throw;
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
