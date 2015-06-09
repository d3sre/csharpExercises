using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var client = new ServiceReference1.Service1Client();
                string output = client.ExtraInput("des");
                Console.WriteLine(output);
                Console.ReadLine();
            }
            catch (Exception)
            {
                
                throw new Exception("Client instanzierung hat nicht geklappt");
            }

        }
    }
}
