using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

 //Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.


class CalcuatingNKFactorials
{
    static void Main()
    {
        Console.WriteLine("Insert first number n: ");
        int numN = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert second number k: ");
        int numK = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNK = 1;
        if ((1 < numK) && (numK < numN) && (numN < 100))
        {
            for (int n = numN; n > numK; n--)
            {
                factorialN = factorialN * n;
            }
            int division = numN - numK;
            for (int i = 1; i <= division; i++)
            {
                factorialNK = factorialNK * i;
            }
            BigInteger result = factorialN /factorialNK;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}