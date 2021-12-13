using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class CalculatorClass<T> where T:IComparable 
    {
        static int Max(int value,int value2)
        {
            return value.CompareTo(value2);
        }
        static T Max<T>(T value,T value2) where T : IComparable
        {
            return  value.CompareTo(value2)>0?value:value2;
        }
        



    }
}
