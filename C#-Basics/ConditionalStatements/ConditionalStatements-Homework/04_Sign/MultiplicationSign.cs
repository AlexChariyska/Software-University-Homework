using System;

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators.

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Insert first number:");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert second number:");
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert third number:");
        double thirdNum = double.Parse(Console.ReadLine());
        if ((firstNum >= 0) && (secondNum >= 0) && (thirdNum >= 0))
        {
            Console.WriteLine("The sign is: positive(+).");
        }
        else if ((firstNum <= 0) && (secondNum <= 0) && (thirdNum <= 0))
        {
            Console.WriteLine("The sign is: negative (-).");
        }
        else if (((firstNum <= 0)  ^ (secondNum <= 0)) ^ (thirdNum <= 0))
        {
            Console.WriteLine("The sign is: negative (-).");
        }
        else
        {
            Console.WriteLine("The sign is: positive(+).");
        }
    }
}

