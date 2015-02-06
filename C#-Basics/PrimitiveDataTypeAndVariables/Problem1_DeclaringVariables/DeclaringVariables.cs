using System;

namespace Problem1_DeclaringVariables
{
    class DeclaringVariables
    {
        static void Main()
        {
            byte num1 = 97;
            sbyte  num2 = -115;
            ushort num3 = 52130;
            short num4 = -10000;
            long num5 = 4826932L;
            Console.WriteLine("The numbers are:\n{0}\n{1}\n{2}\n{3}\n{4}",
                num1, num2, num3, num4, num5);
        }
    }
}
