using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your program should work well for very big numbers

class TrailingZeroes
{
    static void Main()
    {
        Console.WriteLine("Insert number n: ");
        int numN = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        if (numN >= 1)
        {
            for (int n = 1; n <= numN; n++)
            {
                factorial = factorial * n;
            }
            long countZeroes = 0;
            long divider = 5;
            while ((numN / divider) >= 1)
            {
                countZeroes += (numN / divider);
                divider *= 5;
            }
            Console.WriteLine("The Trailing Zeroes in that N Factorial is ZEROES = {0} !",
                countZeroes);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
