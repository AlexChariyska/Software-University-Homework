using System;
using System.Numerics;

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. Print the result with 5 digits after the decimal point. 


class CalculatingSum
{
    static void Main()
    {
        Console.WriteLine("Insert first number n: ");
        int numN = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert second number x: ");
        int numX = int.Parse(Console.ReadLine());
        double factorialN = 1; 
        double powX=1;
        double sum = 1;
        for (double i = 1; i <= numN; i++)
			{
                factorialN = factorialN * i;
                powX = Math.Pow(numX,i);
                sum = sum + factorialN / powX;
			}
        Console.WriteLine("{0:F5}", sum);
    }
}

