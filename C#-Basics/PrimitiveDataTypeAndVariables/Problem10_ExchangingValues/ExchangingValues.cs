using System;

namespace Problem10_ExchangingValues
{
    class ExchangingValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c;
            Console.WriteLine("a= " + a);
            Console.WriteLine("b= " + b);
            c = b;
            b = a;
            a = c;
            Console.WriteLine("a= " + a);
            Console.WriteLine("b= " + b);
        }
    }
}
