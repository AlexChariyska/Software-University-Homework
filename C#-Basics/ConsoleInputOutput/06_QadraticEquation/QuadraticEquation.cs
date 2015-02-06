using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). 

 class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Insert number a:");
        double numberA = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert number b:");
        double numberB = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert number c:");
        double numberC = double.Parse(Console.ReadLine());
        double descriminant = Math.Pow(numberB, 2) - (4* numberA * numberC);
        double x;
        double x1;
        double x2;
        if (descriminant == 0)
        {
            x = (-numberB) / (2 * numberA);
            Console.WriteLine("There is only one root x1=x2= {0}.", x);
        }
        else if (descriminant < 0)
        {
            Console.WriteLine("There are no real roots.");
        }
        else
        {
            x1 = (-numberB - Math.Sqrt(descriminant)) / (2 * numberA);
            x2 = (-numberB + Math.Sqrt(descriminant)) / (2 * numberA);
            Console.WriteLine("Root x1 = {0}. Root x2= {1}.", x1, x2);
        }
    }
}

