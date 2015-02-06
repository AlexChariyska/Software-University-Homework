using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.

namespace Problem13_NullValues
{
    class NullValues
    {
        static void Main()
        {
            int? a = null;
            double? b = null;
            Console.WriteLine("Null literal:" + a);
            Console.WriteLine("Null literal:" + b);
            a = 3;
            b = b + 4;
            Console.WriteLine("Variable with only number:" + a);
            Console.WriteLine("Number with null literal: " + b);
        }
    }
}
