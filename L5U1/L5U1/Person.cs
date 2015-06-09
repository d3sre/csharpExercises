using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5U1
{
    public class Person : IComparable<Person>
    {
        /**
         * Source idea from http://stackoverflow.com/questions/1894399/implementing-icomparable
         * 
         */

        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            return this.Age.CompareTo(other.Age);
        }

        public int CompareTo(object obj)
        {
            var prvPerson = obj as Person;
            if (prvPerson == null) throw  new ArgumentException("wrong object type");
            return CompareTo(prvPerson);
        }

    }
}
