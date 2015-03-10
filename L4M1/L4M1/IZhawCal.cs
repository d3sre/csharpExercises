using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4M1
{
    public interface IZhawCal
    {
        double Add(string e1, string e2);
        double Sub(string e1, string e2);
        double Multi(string e1, string e2);
        double Div(string e1, string e2);
    }
}
