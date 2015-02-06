using System;

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1.

namespace Problem_13_CheckBitAtGivenPosition
{
    class BitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Insert integer");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert bit position:");
            int bitPosition = int.Parse(Console.ReadLine());
            int mask = 1 << bitPosition;
            int exchange = (num & mask);
            int result = exchange >> bitPosition;
            if (result == 1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
