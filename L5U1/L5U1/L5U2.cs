using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5U1
{
    class L5U2
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person() {Name = "Heiri", Age=50},
                new Person() {Age = 20, Name = "Ueli"},
                new Person() {Age = 48, Name = "Heidi"}
            };
             
            people.Sort();

            foreach (var var in people)
            {
                Console.WriteLine("Family has: " + var.Name + ": " + var.Age);
            }
            Console.ReadLine();


        }
    }
}
