using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4M1
{
    class Program : IZhawCal
    {
        
        static void Main(string[] args)
        {
        }

        public double Add(string e1, string e2)
        {    
            

            try
            {
                return TestString(e1) + TestString(e2);
            }
            catch (Exception e)
            {
                
                throw new OwnException("Add method went wrong ", e);
            }
            
        }

        public double Sub(string e1, string e2)
        {
            try
            {
                return TestString(e1) - TestString(e2);
            }
            catch (Exception e)
            {

                throw new OwnException("Sub method went wrong ", e);
            }
            
        }

        public double Multi(string e1, string e2)
        {
            try
            {
                return TestString(e1) * TestString(e2);
            }
            catch (Exception e)
            {

                throw new OwnException("Multi method went wrong ", e);
            }
            
        }

        public double Div(string e1, string e2)
        {
            try
            {
                return TestString(e1) / TestString(e2);
            }
            catch (Exception e)
            {

                throw new OwnException("Div method went wrong ", e);
            }
            
        }

        protected void TestString(string number0, out double number1)
        {

            //return Convert.ToDouble(number);
            if (!double.TryParse(number0, out number1))
            {
                throw new OwnException("The following parameter couldn't be parsed: " + number0);
            }
        }
    }
}
