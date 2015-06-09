using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4M1
{
    public class OwnException : Exception
    {
        public OwnException() : base()
        {
        }

        public OwnException(string message) : base(message)
        {
        }

        public OwnException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
