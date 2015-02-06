using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads 3 integer numbers from the console and prints their sum.

class SumOfThreeIntegers
{
    static void Main()
    {
        Console.WriteLine("Insert first number:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert second number:");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert third number:");
        double num3 = double.Parse(Console.ReadLine());
        double sum = num1 + num2 + num3;
        Console.WriteLine("The sum of the three numbers is: {0}.", sum);
    }
}

