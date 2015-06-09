using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace L10U1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        float Addition(MyCalculator input);

        [OperationContract]
        float Subtraction(MyCalculator input);

        [OperationContract]
        float Multiply(MyCalculator input);

        [OperationContract]
        float Divide(MyCalculator input);


    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "L10U1.ContractType".
    [DataContract]
    public class MyCalculator
    {


        [DataMember]
        public float param1 { get; set; }

        [DataMember]
        public float param2 { get; set; }

    }
}
