using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace L3M1
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private static int retirementAge;

        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Employee(int age = 1)
        {
            this.Age = age;
        }

        static Employee()
        {
            retirementAge = 63;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = string.IsNullOrWhiteSpace(_firstName) ? "KeinName" : value; }
        }

        public string LastName
        {
            get { return _lastName;}
            set { _lastName = string.IsNullOrWhiteSpace(_lastName) ? "KeinName" : value; }
        }

        public int Age { get; set; }

        public double Salary { get; set; }

        public Guid ID { get; set; }

    }
}
