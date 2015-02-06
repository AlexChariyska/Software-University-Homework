using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). 

class CalcuatingNKFactorials
{
    static void Main()
    {
        Console.WriteLine("Insert first number n: ");
        int numN = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert second number k: ");
        int numK = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        if ((1 < numK)  && (numN < 100) && numK<numN)
        {
            for (int i =numN; i > numK; i--)
            {
                factorialN = factorialN * i;
            }
            Console.WriteLine(factorialN);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}

