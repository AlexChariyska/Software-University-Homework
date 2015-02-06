using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Principle of Euclid's algorithm:To compute gcd(48,18), divide 48 by 18 to get a quotient of 2 and a remainder of 12. Then divide 18 by 12 to get a quotient of 1 and a remainder of 6. Then divide 12 by 6 to get a remainder of 0, which means that 6 is the gcd.

class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine("Insert a:");
        int numA = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert b:");
        int numB = int.Parse(Console.ReadLine());
        int result;
        do
        {
            result = numA % numB;
            numA = numB;
            numB = result;

        } while (result != 0);
        Console.WriteLine(numA);
    }
}
