using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace L5M1
{
    class Program
    {
        static ArrayList list1 = new ArrayList();
        static SortedList list3 = new SortedList();
        static List<string> list2 = new List<string>();
        static List<int> list4 = new List<int>();

        static void Main(string[] args)
        {
            Test();

            PrintValueNonGeneric(list1);
            PrintValueNonGeneric(list3);
            PrintValuesGenericString(list2);
            PrintValuesGenericInt(list4);

            Console.ReadLine();
        }

        public static void Test()
        {

            //nicht generisch
            //ArrayList list1 = new ArrayList();
            list1.Add("Alice");
            list1.Add("Bob");
            list1.Add("Charlie");

            //SortedList list3 = new SortedList();
            list3.Add(1,"Alpha");
            list3.Add(3,"Gamma");
            list3.Add(2,"Beta");

            //generisch
            //List<string> list2 = new List<string>();
            list2.Add("Bobby");
            list2.Add("Christina");
            list2.Add("Debora");

            //List<int> list4 = new List<int>();
            list4.Add(1);
            list4.Add(3);
            list4.Add(6);
            list4.Add(2);


        }

        private static void PrintValuesGenericString(IEnumerable generic)
        {
            foreach (string s in generic)
            {
                Console.WriteLine(s);
            }
        }

        private static void PrintValuesGenericInt(IEnumerable generic)
        {
            foreach (int i in generic)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintValueNonGeneric(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
