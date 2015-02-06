using System;

//We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

namespace Problem14_ModifyBitAtGivenPosition
{
    class ModifyBitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Insert integer");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert bit position:");
            int bitPosition = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert bit value:");
            byte value = byte.Parse(Console.ReadLine());
            int mask;
            int result;
            if (value == 1)
            {
                mask = 1 << bitPosition;
                result = mask | num;
                Console.WriteLine(result);
            }
            else
            {
                mask = ~(1 << bitPosition);
                result = mask & num;
                Console.WriteLine(result);
            }
        }
    }
}
