using System;

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0.

namespace Problem11_BitwiseExtract
{
    class BitwiseExtractBit3
    {
        static void Main()
        {
            Console.WriteLine("Insert number and bit position.");
            int number = int.Parse(Console.ReadLine());
            int bitPosition = 3;
            int mask = 1 << bitPosition;
            int sum = (number & mask);
            int result = sum >> bitPosition;
            Console.WriteLine(result);
        }
    }
}
