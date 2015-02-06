using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that extracts from given integer n the value of given bit at index p.

namespace Problem12_ExtractBitFromInteger
{
    class ExtractBit
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
            Console.WriteLine(result);
        }
    }
}
