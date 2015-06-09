using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace L10U1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Calculator : ICalculator
    {
    
        public float Addition(MyCalculator input)
        {
            return input.param1 + input.param2;
        }

        public float Subtraction(MyCalculator input)
        {
            return input.param1 - input.param2;
        }

        public float Multiply(MyCalculator input)
        {
            return input.param1 * input.param2;
        }

        public float Divide(MyCalculator input)
        {
            return input.param1 / input.param2;
        }
}
}
