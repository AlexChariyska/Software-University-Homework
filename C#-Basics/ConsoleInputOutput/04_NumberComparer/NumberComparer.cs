using System;

//Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements. 

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Inser number a:");
        double numberA = double.Parse(Console.ReadLine());
        Console.WriteLine("Inser number b:");
        double numberB = double.Parse(Console.ReadLine());
        double greaterNumber = Math.Max(numberA, numberB);
        Console.WriteLine("The bigger number is: {0}", greaterNumber);
    }
}

